using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Don_banano
{
    public partial class FormCliente : Form
    {
        private List<Pedido> entregasPendientes = new List<Pedido>();
        private Queue<Pedido> colaEntregas = new Queue<Pedido>();

        private FormRepartidor FormRepartidor;
        public FormCliente(FormRepartidor repartidor)
        {
            InitializeComponent();
            FormRepartidor = repartidor;
        }

        private Pedido CrearPedidoDesdeFormulario()
        {
            Random rnd = new Random();
            int numeroOrden = rnd.Next(1000, 9999);

            string productos = "";
            foreach (ListViewItem item in listViewProductos.CheckedItems)
            {
                productos += item.Text + ", ";
            }
            productos = productos.TrimEnd(',', ' ');

            return new Pedido
            {
                Orden = numeroOrden,
                Cliente = txtNombreCliente.Text,
                Direccion = txtDireccion.Text,
                Productos = productos,
                Sucursal = cmbSucursal.Text,
                HoraCreacion = DateTime.Now
            };
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pedido nuevoPedido = new Pedido
            {
                Cliente = txtNombreCliente.Text,
                Direccion = txtDireccion.Text,
                Sucursal = cmbSucursal.SelectedItem.ToString(),
                Productos = "Producto 1", // puedes reemplazarlo con una lista si quieres
                HoraCreacion = DateTime.Now
            };

            nuevoPedido = CrearPedidoDesdeFormulario(); // tu método para crear el pedido
            FormRepartidor.AgregarPedidoAPendientes(nuevoPedido);

            // Actualizar cola ordenada por hora
            var ordenados = entregasPendientes.OrderBy(p => p.HoraCreacion).ToList();
            colaEntregas.Clear();
            foreach (var p in ordenados)
            {
                colaEntregas.Enqueue(p);
            }

            // Mostrar en panel de entrega actual si es el primero
            
        }
    }
}

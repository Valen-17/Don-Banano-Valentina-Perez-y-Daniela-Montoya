using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Don_banano
{
    public partial class FormCliente : Form
    {
        private List<Pedido> entregasPendientes = new List<Pedido>();
        private Queue<Pedido> colaEntregas = new Queue<Pedido>();

        private FormRepartidor _formRepartidor;

        public FormCliente(FormRepartidor repartidor)
        {
            InitializeComponent();
            _formRepartidor = repartidor;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // Cargar sucursales únicas en el ComboBox
            var sucursales = Inventario.ListaProductos
                .Select(p => p.Sucursal)
                .Distinct()
                .ToList();

            cmbSucursal.Items.Clear();
            cmbSucursal.Items.AddRange(sucursales.ToArray());
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sucursalSeleccionada = cmbSucursal.SelectedItem.ToString();
            CargarProductosPorSucursal(sucursalSeleccionada);
        }

        private void CargarProductosPorSucursal(string sucursalSeleccionada)
        {
            listViewProductos.Items.Clear();

            foreach (var producto in Inventario.ListaProductos)
            {
                if (producto.Sucursal == sucursalSeleccionada && producto.Estado == "Disponible")
                {
                    ListViewItem item = new ListViewItem(producto.Nombre);
                    item.SubItems.Add(producto.Precio.ToString("0.00"));
                    item.SubItems.Add(producto.Sucursal);
                    item.Checked = false;
                    listViewProductos.Items.Add(item);
                }
            }
        }

        private Pedido CrearPedidoDesdeFormulario()
        {
            Random rnd = new Random();
            int numeroOrden = rnd.Next(1000, 9999);

            string productos = string.Join(", ",
                listViewProductos.CheckedItems
                    .Cast<ListViewItem>()
                    .Select(item => item.Text)
                    .ToArray());

            return new Pedido()
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
            // Crear y agregar el pedido
            Pedido nuevoPedido = CrearPedidoDesdeFormulario();
            entregasPendientes.Add(nuevoPedido);
            _formRepartidor.AgregarPedidoAPendientes(nuevoPedido);

            // Reordenar por hora de creación
            var ordenados = entregasPendientes.OrderBy(p => p.HoraCreacion).ToList();
            colaEntregas.Clear();
            foreach (var p in ordenados)
            {
                colaEntregas.Enqueue(p);
            }

            // (Opcional) Mostrar en ListView del cliente
            ActualizarListViewPedidos();
        }

        private void ActualizarListViewPedidos()
        {
            if (listViewProductos == null) return;

            listViewProductos.Items.Clear();

            foreach (var pedido in entregasPendientes)
            {
                ListViewItem item = new ListViewItem(pedido.Orden.ToString());
                item.SubItems.Add(pedido.Cliente);
                item.SubItems.Add(pedido.Direccion);
                item.SubItems.Add(pedido.Productos);
                item.SubItems.Add(pedido.Sucursal);
                item.SubItems.Add(pedido.HoraCreacion.ToString("HH:mm:ss"));
                listViewProductos.Items.Add(item);
            }
        }
    }
}


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
            // Evitar duplicados usando HashSet
            HashSet<string> sucursalesUnicas = new HashSet<string>();

            // Recorrer la lista de productos
            foreach (var producto in Inventario.ListaProductos)
            {
                sucursalesUnicas.Add(producto.Sucursal);
            }

            // Limpiar el ComboBox antes de llenarlo
            cmbSucursal.Items.Clear();

            // Agregar un item por defecto
            cmbSucursal.Items.Add("0. Selecciona la sucursal");

            // Agregar las sucursales únicas
            foreach (var sucursal in sucursalesUnicas)
            {
                cmbSucursal.Items.Add(sucursal);
            }

            // Seleccionar por defecto el primer ítem
            cmbSucursal.SelectedIndex = 0;
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel_crearPedido.Visible = true;
            panel_crearPedido.BringToFront();
            int x = (this.ClientSize.Width - panel_crearPedido.Width) / 2;
            int y = (this.ClientSize.Height - panel_crearPedido.Height) / 2;
            panel_crearPedido.Location = new System.Drawing.Point(x, y);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = true;
            guna2Panel4.BringToFront();
            int x = (this.ClientSize.Width - guna2Panel4.Width) / 2;
            int y = (this.ClientSize.Height - guna2Panel4.Height) / 2;
            guna2Panel4.Location = new System.Drawing.Point(x, y);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}


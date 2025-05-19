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
    public partial class FormVendedor : Form
    {
        private FormRepartidor _formRepartidor;
        private List<Pedido> pedidosCreados = new List<Pedido>();
        private Queue<Pedido> colaPedidos = new Queue<Pedido>();

        public FormVendedor(FormRepartidor repartidor)
        {
            InitializeComponent();
            _formRepartidor = repartidor;
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {
            CargarVistaInventario();
        }

        private void CargarSucursales()
        {
            var sucursales = Inventario.ListaProductos
                .Select(p => p.Sucursal)
                .Distinct()
                .ToList();

            cmbSucursal.Items.Clear();
            cmbSucursal.Items.AddRange(sucursales.ToArray());
        }


        private void CargarVistaInventario()
        {
            listViewInventario.Items.Clear();

            foreach (var producto in Inventario.ListaProductos)
            {
                ListViewItem item = new ListViewItem(producto.Sucursal);
                item.SubItems.Add(producto.Estado);
                item.SubItems.Add(producto.Nombre);
                listViewInventario.Items.Add(item);
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbSucursal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sucursalSeleccionada = cmbSucursal.SelectedItem.ToString();
            listView_vendedor_pedidos.Items.Clear();

            foreach (var producto in Inventario.ListaProductos)
            {
                if (producto.Sucursal == sucursalSeleccionada && producto.Estado == "Disponible")
                {
                    ListViewItem item = new ListViewItem(producto.Nombre);
                    item.SubItems.Add(producto.Estado);
                    item.SubItems.Add(producto.Sucursal);
                    item.Checked = false;
                    listView_vendedor_pedidos.Items.Add(item);
                }
            }
        }
        private Pedido CrearPedido()
        {
            Random rnd = new Random();
            int numeroOrden = rnd.Next(1000, 9999);

            string productos = string.Join(", ",
                listView_vendedor_pedidos.CheckedItems
                    .Cast<ListViewItem>()
                    .Select(item => item.Text)
                    .ToArray());

            return new Pedido(
                numeroOrden,
                txtNombreCliente.Text,
                txtDireccion.Text,
                productos,
                cmbSucursal.Text
            );
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel_crearpedido.Visible = false;
            panel_crearpedido.SendToBack();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel_crearpedido.Visible = true;
            panel_crearpedido.BringToFront();
            int x = (this.ClientSize.Width - panel_crearpedido.Width) / 2;
            int y = (this.ClientSize.Height - panel_crearpedido.Height) / 2;
            panel_crearpedido.Location = new System.Drawing.Point(x, y);
        }

        private void cerrarInventarioVendedor_Click(object sender, EventArgs e)
        {
            panelInventarioVendedor.Visible = false;
            panelInventarioVendedor.SendToBack();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelInventarioVendedor.Visible = true;
            panelInventarioVendedor.BringToFront();
            int x = (this.ClientSize.Width - panelInventarioVendedor.Width) / 2;
            int y = (this.ClientSize.Height - panelInventarioVendedor.Height) / 2;
            panelInventarioVendedor.Location = new System.Drawing.Point(x, y);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

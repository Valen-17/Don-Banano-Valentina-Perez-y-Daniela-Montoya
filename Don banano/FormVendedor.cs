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
        public FormVendedor()
        {
            InitializeComponent();
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {
            CargarVistaInventario();
            CargarSucursales();
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

        private void btn_finalizarVenta_Click(object sender, EventArgs e)
        {
            if (listView_vendedor_pedidos.SelectedItems.Count > 0 && cmbSucursal.SelectedItem != null)
            {
                string numeroOrden = Guid.NewGuid().ToString().Substring(0, 8);
                string cliente = txtNombreCliente.Text;
                string direccion = txtDireccion.Text;
                string producto = listView_vendedor_pedidos.SelectedItems[0].Text;
                string sucursal = cmbSucursal.SelectedItem.ToString();
                string hora = DateTime.Now.ToString("g");

                string resumen = $"Número de Orden: {numeroOrden}\n" +
                                 $"Cliente: {cliente}\n" +
                                 $"Dirección: {direccion}\n" +
                                 $"Sucursal: {sucursal}\n" +
                                 $"Producto: {producto}\n" +
                                 $"Hora: {hora}";

                MessageBox.Show(resumen, "Resumen de tu compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto y una sucursal");
            }
        }

        private void listView_vendedor_pedidos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView_vendedor_pedidos.SelectedItems.Count > 0)
            {
                var item = listView_vendedor_pedidos.SelectedItems[0];
                var producto = (Producto)item.Tag;

                txt_producto.Text = producto.Nombre;
                txt_precio.Text = producto.Precio.ToString("N2");
                txt_cantidad.Text = "";
                panel_cantidadProductos.Visible = true;

                panel_crearpedido.Visible = false;
                panel_crearpedido.SendToBack();
            }
        }
    }
}

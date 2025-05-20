using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Don_banano
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void CargarSucursales()
        {
            var sucursalesUnicas = Inventario.ListaProductos
                .Select(p => p.Sucursal)
                .Distinct()
                .ToList();

            cmbSucursal.Items.Clear();
            cmbSucursal.Items.AddRange(sucursalesUnicas.ToArray());
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sucursalSeleccionada = cmbSucursal.SelectedItem.ToString();
            listViewProductos.Items.Clear();

            var productosFiltrados = Inventario.ListaProductos
                .Where(p => p.Sucursal == sucursalSeleccionada)
                .ToList();

            foreach (var producto in productosFiltrados)
            {
                var item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Precio.ToString("N2"));
                item.Tag = producto;
                listViewProductos.Items.Add(item);
            }
        }

        private void FormCliente_Load_1(object sender, EventArgs e)
        {
            CargarSucursales();

            listViewProductos.Items.Clear();
            foreach (var producto in Inventario.ListaProductos)
            {
                var item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Precio.ToString("N2"));
                item.SubItems.Add(producto.Sucursal);
                item.Tag = producto;
                listViewProductos.Items.Add(item);
            }
        }

        private void listViewProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewProductos.SelectedItems.Count > 0)
            {
                var item = listViewProductos.SelectedItems[0];
                var producto = (Producto)item.Tag;

                txt_producto.Text = producto.Nombre;
                txt_precio.Text = producto.Precio.ToString("N2");
                txt_cantidad.Text = "";
                panel_cantidadProductos.Visible = true;

                panel_crearPedido.Visible = false;
                panel_crearPedido.SendToBack();
            }
        }

        private void btn_cerrarCrearPedido_Click(object sender, EventArgs e)
        {
            panel_crearPedido.Visible = false;
            panel_crearPedido.SendToBack();
        }

        private void btn_cerrarCantidadProductos_Click(object sender, EventArgs e)
        {
            panel_cantidadProductos.Visible = false;
            panel_cantidadProductos.SendToBack();
        }

        private void btn_CancelarPedido_Click(object sender, EventArgs e)
        {
            panel_CancelarPedido.Visible = false;
            panel_CancelarPedido.SendToBack();
        }

        private void CrearPedido_Click(object sender, EventArgs e)
        {
            panel_crearPedido.Visible = true;
            panel_crearPedido.BringToFront();
            int x = (this.ClientSize.Width - panel_crearPedido.Width) / 2;
            int y = (this.ClientSize.Height - panel_crearPedido.Height) / 2;
            panel_crearPedido.Location = new System.Drawing.Point(x, y);
        }

        private void CancelarPedido_Click(object sender, EventArgs e)
        {
            panel_CancelarPedido.Visible = true;
            panel_CancelarPedido.BringToFront();
            int x = (this.ClientSize.Width - panel_CancelarPedido.Width) / 2;
            int y = (this.ClientSize.Height - panel_CancelarPedido.Height) / 2;
            panel_CancelarPedido.Location = new System.Drawing.Point(x, y);
        }

        private void btn_cerrarFormCliente_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_finalizarVenta_Click(object sender, EventArgs e)
        {
            if (listViewProductos.SelectedItems.Count > 0 && cmbSucursal.SelectedItem != null)
            {
                string numeroOrden = Guid.NewGuid().ToString().Substring(0, 8);
                string cliente = txtNombreCliente.Text;
                string direccion = txtDireccion.Text;
                string producto = listViewProductos.SelectedItems[0].Text;
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
    }
}


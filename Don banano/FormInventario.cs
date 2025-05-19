using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Don_banano;

namespace Don_banano
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
            CargarInventario();
        }
        
        //Agregar productos al inventario
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            panel_agregar.Visible = true;
            panel_agregar.BringToFront();
            int x = (this.ClientSize.Width - panel_agregar.Width) / 2;
            int y = (this.ClientSize.Height - panel_agregar.Height) / 2;
            panel_agregar.Location = new Point(x, y);

        }
        private void btn_cancelarA_Click(object sender, EventArgs e)
        {
            panel_agregar.Visible = false;
            panel_agregar.SendToBack();
        }
        private void btn_guardarA_Click(object sender, EventArgs e)
        {
            string nuevoProducto = txt_producto.Text.Trim();
            string nuevaSucursal = txt_sucursal.Text.Trim();
            string nuevaDireccion = txt_direccion.Text.Trim();
            string textoStock = txt_stock.Text.Trim();
            string textoPrecio = txt_precio.Text.Trim();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(nuevoProducto) || string.IsNullOrEmpty(nuevaSucursal) ||
                string.IsNullOrEmpty(nuevaDireccion) || string.IsNullOrEmpty(textoStock) || string.IsNullOrEmpty(textoPrecio))
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            if (!int.TryParse(textoStock, out int stock))
            {
                MessageBox.Show("El stock debe ser un número entero.");
                return;
            }

            if (!decimal.TryParse(textoPrecio, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número decimal.");
                return;
            }

            if (Inventario.ListaProductos.Exists(p => p.Nombre.Equals(nuevoProducto, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe un producto con ese nombre.");
                return;
            }

            // Agregar producto
            Producto productoNuevo = new Producto(nuevoProducto, stock, nuevaSucursal, precio, nuevaDireccion);
            Inventario.ListaProductos.Add(productoNuevo);
            MessageBox.Show("Producto agregado correctamente.");

            txt_producto.Clear();
            txt_stock.Clear();
            txt_sucursal.Clear();
            txt_precio.Clear();
            txt_direccion.Clear();
            panel_agregar.Visible = false;
            panel_agregar.SendToBack();

            CargarInventario();
        }

        //Editar productos del inventario
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (listView_inventario.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un vendedor para editar.");
                return;
            }

            ListViewItem item = listView_inventario.SelectedItems[0];
            txt_producto.Text = item.SubItems[0].Text;
            txt_stock.Text = item.SubItems[1].Text;
            txt_sucursal.Text = item.SubItems[2].Text;
            txt_precio.Text = item.SubItems[3].Text;
            txt_direccion.Text = item.SubItems[4].Text;

            panel_editar.Visible = true;
            panel_editar.BringToFront();
            int x = (this.ClientSize.Width - panel_editar.Width) / 2;
            int y = (this.ClientSize.Height - panel_editar.Height) / 2;
            panel_editar.Location = new System.Drawing.Point(x, y);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nuevoProducto = txt_producto.Text.Trim();
            string nuevaSucursal = txt_sucursal.Text.Trim();
            string nuevaDireccion = txt_direccion.Text.Trim();

            if (string.IsNullOrEmpty(nuevoProducto) || string.IsNullOrEmpty(nuevaSucursal) || string.IsNullOrEmpty(nuevaDireccion))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }

            if (!int.TryParse(txt_stock.Text.Trim(), out int stock) || !decimal.TryParse(txt_precio.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }

            string productoOriginal = listView_inventario.SelectedItems[0].SubItems[0].Text;

            // Buscar producto en la lista global
            Producto producto = Inventario.ListaProductos.Find(p => p.Nombre == productoOriginal);

            if (producto != null)
            {
                producto.Nombre = nuevoProducto;
                producto.Stock = stock;
                producto.Sucursal = nuevaSucursal;
                producto.Precio = precio;
                producto.Direccion = nuevaDireccion;

                MessageBox.Show("Producto editado correctamente.");

                CargarInventario();
                panel_editar.Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontró el producto a editar.");
            }
        }

        private void CargarInventario()
        {
            listView_inventario.Items.Clear();

            foreach (var producto in Inventario.ListaProductos)
            {
                ListViewItem item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Stock.ToString());
                item.SubItems.Add(producto.Sucursal);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Direccion);

                listView_inventario.Items.Add(item);
            }
        }

    }
}

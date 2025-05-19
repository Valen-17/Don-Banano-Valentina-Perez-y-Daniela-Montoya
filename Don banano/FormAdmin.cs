using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Don_banano;

namespace Don_banano
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btn_vendedores_Click(object sender, EventArgs e)
        {
            FormAgregarVendedor formAgregar = new FormAgregarVendedor();
            formAgregar.Show();
            this.Hide();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 formPrincipal = new Form1();
            formPrincipal.Show();
            this.Hide();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            FormInventario formInventario = new FormInventario();
            formInventario.Show();
            this.Hide();
        }

        // Mostrar el panel de venta con los productos cargados
        private void btn_vender_Click(object sender, EventArgs e)
        {
            Facturar.ProductosVendidos.Clear();
            panel_vender.Visible = true;
            panel_vender.BringToFront();
            int x = (this.ClientSize.Width - panel_vender.Width) / 2;
            int y = (this.ClientSize.Height - panel_vender.Height) / 2;
            panel_vender.Location = new Point(x, y);

            CargarProductos();
        }

        // Cargar productos desde el inventario a listView_vender
        private void CargarProductos()
        {
            listView_vender.Items.Clear();

            foreach (var producto in Inventario.ListaProductos)
            {
                ListViewItem item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Precio.ToString("0.00"));
                item.SubItems.Add(producto.Sucursal);
                listView_vender.Items.Add(item);
            }
        }

        // Abrir el panel para seleccionar cantidad del producto
        private void btn_venderP_Click(object sender, EventArgs e)
        {
            if (listView_vender.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para vender.");
                return;
            }

            ListViewItem item = listView_vender.SelectedItems[0];
            string nombreSeleccionado = item.SubItems[0].Text;
            string precioSeleccionado = item.SubItems[1].Text;
            string sucursalSeleccionada = item.SubItems[2].Text;

            txt_producto.Text = nombreSeleccionado;
            txt_precio.Text = precioSeleccionado;

            //Sucursal del producto
            Producto productoSeleccionado = Inventario.ListaProductos.Find(p => p.Nombre == nombreSeleccionado && p.Sucursal == sucursalSeleccionada);

            if (productoSeleccionado == null)
            {
                MessageBox.Show("No se encontró el producto exacto en el inventario.");
                return;
            }

            panel_vender2.Visible = true;
            panel_vender2.BringToFront();
            int x = (this.ClientSize.Width - panel_vender2.Width) / 2;
            int y = (this.ClientSize.Height - panel_vender2.Height) / 2;
            panel_vender2.Location = new Point(x, y);
        }

        // Guardar producto con cantidad y descontar del stock
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nombre = txt_producto.Text.Trim();
            string precioTexto = txt_precio.Text.Trim();
            string cantidadTexto = txt_cantidad.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(precioTexto) || string.IsNullOrEmpty(cantidadTexto))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }

            if (!decimal.TryParse(precioTexto, out decimal precio) || !int.TryParse(cantidadTexto, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Valores inválidos");
                return;
            }

            Producto producto = Inventario.ListaProductos.Find(p => p.Nombre == nombre);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado");
                return;
            }

            if (producto.Stock < cantidad)
            {
                MessageBox.Show($"Stock insuficiente, solo hay {producto.Stock} unidades");
                return;
            }

            Facturar.ProductosVendidos.Add(new ProductoVendido(nombre, cantidad, precio));
            producto.Stock -= cantidad;

            MessageBox.Show("Producto agregado a la venta");

            txt_producto.Clear();
            txt_precio.Clear();
            txt_cantidad.Clear();

            panel_vender2.Visible = false;
            panel_vender.Visible = true;
            CargarProductos();
        }

        // Mostrar factura con productos del carrito
        private void btn_finalizarVenta_Click(object sender, EventArgs e)
        {
            // Validar si hay un producto en el panel de venta que aún no se ha guardado
            if (panel_vender2.Visible)
            {
                string nombre = txt_producto.Text.Trim();
                string precioTexto = txt_precio.Text.Trim();
                string cantidadTexto = txt_cantidad.Text.Trim();

                if (!string.IsNullOrEmpty(nombre) &&
                    !string.IsNullOrEmpty(precioTexto) &&
                    !string.IsNullOrEmpty(cantidadTexto) &&
                    decimal.TryParse(precioTexto, out decimal precio) &&
                    int.TryParse(cantidadTexto, out int cantidad) &&
                    cantidad > 0)
                {
                    Producto producto = Inventario.ListaProductos.Find(p => p.Nombre == nombre);

                    if (producto != null)
                    {
                        if (producto.Stock >= cantidad)
                        {
                            Facturar.ProductosVendidos.Add(new ProductoVendido(nombre, cantidad, precio));
                            producto.Stock -= cantidad;

                            // Limpiar campos
                            txt_producto.Clear();
                            txt_precio.Clear();
                            txt_cantidad.Clear();
                        }
                        else
                        {
                            MessageBox.Show($"Stock insuficiente, solo hay {producto.Stock} unidades.");
                            return;
                        }
                    }
                }
            }

            // Si no hay productos agregados, mostrar error
            if (Facturar.ProductosVendidos.Count == 0)
            {
                MessageBox.Show("No hay productos agregados para la venta");
                return;
            }

            panel_vender2.Visible = false;
            panel_vender.Visible = false;
            panel_factura.Visible = true;
            panel_factura.BringToFront();
            int x = (this.ClientSize.Width - panel_factura.Width) / 2;
            int y = (this.ClientSize.Height - panel_factura.Height) / 2;
            panel_factura.Location = new Point(x, y);

            listView_factura.Items.Clear();
            decimal total = 0;

            foreach (var item in Facturar.ProductosVendidos)
            {
                ListViewItem fila = new ListViewItem(item.Nombre);
                fila.SubItems.Add(item.PrecioUnitario.ToString("0.00"));
                fila.SubItems.Add(item.Cantidad.ToString());
                fila.SubItems.Add(item.Subtotal.ToString("0.00"));
                listView_factura.Items.Add(fila);
                total += item.Subtotal;
            }

            lbl_total.Text = $"Total: {total:C}";
            CargarProductos();
        }


        // Cerrar panel de factura
        private void btn_cerrarV_Click(object sender, EventArgs e)
        {
            Facturar.ProductosVendidos.Clear();
            listView_factura.Items.Clear();
            lbl_total.Text = "";

            panel_factura.Visible = false;
            panel_vender.Visible = true;
            CargarProductos();
        }

        // Cerrar cualquier panel
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            panel_vender.Visible = false;
            panel_vender.SendToBack();
            panel_vender2.Visible = false;
            panel_vender2.SendToBack();
            panel_factura.Visible = false;
            panel_factura.SendToBack();
        }

        private void btn_cerrarFactura_Click(object sender, EventArgs e)
        {
            panel_factura.Visible = false;
            panel_factura.SendToBack();
        }
    }
}


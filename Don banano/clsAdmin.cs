using System;
using System.Windows.Forms; // Necesario para usar MessageBox

namespace Don_banano
{
    public class clsAdmin : clsTrabajador
    {
        public clsAdmin(string nombre, string documento) : base(nombre, documento) { }

        public void AgregarProducto(clsSucursal sucursal, clsProducto producto)
        {
            sucursal.AgregarProducto(producto);
            MessageBox.Show($"Producto '{producto.Nombre}' agregado correctamente a la sucursal {sucursal.Nombre}.", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void VenderProducto(clsSucursal sucursal, string productoId, int cantidad)
        {
            bool vendido = sucursal.VenderProducto(productoId, cantidad);

            if (vendido)
            {
                MessageBox.Show("Venta realizada con éxito.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la venta. Verifica el ID o la cantidad.", "Error en venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void GenerarFactura(clsCliente cliente, clsProducto producto, int cantidad)
        {
            decimal total = producto.Precio * cantidad;
            string mensaje = $"Factura para {cliente.Nombre}:\n{cantidad} x {producto.Nombre} = ${total}";
            MessageBox.Show(mensaje, "Factura generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

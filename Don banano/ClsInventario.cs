using System;
using System.Collections.Generic;

namespace Don_banano
{
    public class clsSucursal
    {
        public string Nombre { get; set; }
        public List<clsProducto> Inventario { get; set; }

        public clsSucursal(string nombre)
        {
            Nombre = nombre;
            Inventario = new List<clsProducto>();
        }

        public void AgregarProducto(clsProducto producto)
        {
            Inventario.Add(producto);
        }

        public bool VenderProducto(string id, int cantidad)
        {
            var producto = Inventario.Find(p => p.Id == id);
            if (producto != null && producto.Cantidad >= cantidad)
            {
                producto.Cantidad -= cantidad;
                return true;
            }
            return false;
        }

        public clsProducto BuscarProducto(string id)
        {
            return Inventario.Find(p => p.Id == id);
        }

        public List<clsProducto> ObtenerInventario()
        {
            return Inventario;
        }
    }
}

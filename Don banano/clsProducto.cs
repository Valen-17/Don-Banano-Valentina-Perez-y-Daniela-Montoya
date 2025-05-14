using System;

namespace Don_banano
{
    public class clsProducto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public clsProducto(string id, string nombre, int cantidad, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}

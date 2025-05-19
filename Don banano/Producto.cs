namespace Don_banano
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public string Sucursal { get; set; }
        public decimal Precio { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; internal set; }

        public Producto(string nombre, int stock, string sucursal, decimal precio, string direccion)
        {
            Nombre = nombre;
            Stock = stock;
            Sucursal = sucursal;
            Precio = precio;
            Direccion = direccion;
        }
    }
}

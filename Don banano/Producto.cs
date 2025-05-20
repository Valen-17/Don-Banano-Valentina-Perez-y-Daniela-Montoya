namespace Don_banano
{
    public class Producto
    {
        private string nuevoProducto;
        private string nuevaSucursal;
        private string nuevaDireccion;

        public string Orden {  get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public string Sucursal { get; set; }
        public decimal Precio { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; internal set; }

        public Producto(string orden, string nombre, int stock, string sucursal, decimal precio, string direccion)
        {
            Orden = orden; // ← ¡Faltaba esto!
            Nombre = nombre;
            Stock = stock;
            Sucursal = sucursal;
            Precio = precio;
            Direccion = direccion;
            Estado = "Disponible";
        }

        public Producto(string nuevoProducto, int stock, string nuevaSucursal, decimal precio, string nuevaDireccion)
        {
            this.nuevoProducto = nuevoProducto;
            Stock = stock;
            this.nuevaSucursal = nuevaSucursal;
            Precio = precio;
            this.nuevaDireccion = nuevaDireccion;
        }
    }
}

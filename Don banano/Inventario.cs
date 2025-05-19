using System.Collections.Generic;

namespace Don_banano
{
    public static class Inventario
    {
        public static List<Producto> ListaProductos { get; set; } = new List<Producto>();
        public static bool InventarioCargado { get; set; } = false;
        static Inventario()
        {
            // Se ejecuta una sola vez cuando se usa la clase por primera vez
            ListaProductos.Add(new Producto("Banano", 100, "San Diego", 1000, "Dirección 1"));
            ListaProductos.Add(new Producto("Manzana", 50, "Manrique", 1500, "Dirección 2"));
            ListaProductos.Add(new Producto("Uvas", 75, "Los Colores", 2000, "Dirección 3"));
        }
    }

}

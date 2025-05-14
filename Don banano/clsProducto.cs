using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Don_banano
{
    internal class clsProducto
    {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }

            public Producto(string id, string nombre, int cantidad, decimal precio)
            {
                this.Id = id;
                this.Nombre = nombre;
                this.Cantidad = cantidad;
                this.Precio = precio;
            }
        

    }
}

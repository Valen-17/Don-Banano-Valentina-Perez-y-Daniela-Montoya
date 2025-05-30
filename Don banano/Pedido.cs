﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Don_banano
{
    public class Pedido
    {
        public string Orden { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Productos { get; set; }
        public string Sucursal { get; set; }
        public DateTime HoraCreacion { get; set; }
        public List<Producto> Producto { get; set; } = new List<Producto>();


        public Pedido(string orden, string cliente, string direccion, string productos, string sucursal)
        {
            Orden = orden;
            Cliente = cliente;
            Direccion = direccion;
            Productos = productos;
            Sucursal = sucursal;
            HoraCreacion = DateTime.Now;
        }

        public Pedido(int numeroOrden)
        {
        }
    }
}

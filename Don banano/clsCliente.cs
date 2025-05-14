using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Don_banano
{
    public class clsCliente : clsPersona
    {
        public string Direccion { get; set; }
        public clsCliente(string nombre, string documento, string direccion) : base(nombre, documento)
        {
            Direccion = direccion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Don_banano
{
    public class clsPersona
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }

        public clsPersona(string nombre, string documento)
        {
            Nombre = nombre;
            Documento = documento;
        }
    }
}

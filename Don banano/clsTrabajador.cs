using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Don_banano
{
    public class clsTrabajador : clsPersona
    {
        public clsTrabajador(string nombre, string documento) : base(nombre, documento) { }

        public virtual void MostrarInventario(clsSucursal sucursal)
        {
            sucursal.ObtenerInventario();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Movimiento
    {
        public Movimiento(int id, string descripcion, double monto)
        {
            this.id = id;
            this.fecha = DateTime.Now;
            this.descripcion = descripcion;
            this.monto = monto;
        }

        public int id { get; private set; }
        public DateTime fecha { get; private set; }
        public string descripcion { get; private set; }
        public double monto { get; private set; }
    }
}

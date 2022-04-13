using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public string dni { get; private set; }
        public double saldo {
            get { return saldo; }
            set { saldo += value; }
        }
        public List<Movimiento> historialMovimientos { get; private set; }
    }
}

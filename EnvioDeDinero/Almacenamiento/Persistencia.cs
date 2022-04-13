using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Almacenamiento
{
    public class Persistencia
    {
        // Hacer de cuenta que se manejan JSON
        public List<Usuario> usuarios { get; private set; }
    }
}

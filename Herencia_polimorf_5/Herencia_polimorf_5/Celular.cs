using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_polimorf_5
{
    internal class Celular:Producto
    {
        public int VelocidadProcesador { get; set; }
        public int CapacidadAlmacenamiento { get; set; }
        public string SistemaOperativo { get; set; }

    }
}

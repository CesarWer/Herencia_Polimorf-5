using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_polimorf_5
{
    internal class Computadoras:Producto
    {
        public int RAM { get; set; }
        public int VelocidadProcesamiento { get; set; }
        public int CapacidadAlmacenamiento { get; set; }
        public bool Notebook { get; set; }
    }
}

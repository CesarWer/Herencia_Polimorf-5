using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_polimorf_5
{
    internal class Producto
    {
        public int Codigo { get; set; }
        public string CodigoMarca { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int PrecioLista { get; set; }
        public int PorcentajeDescuento { get; set; }
        public int AñosGarantia { get; set; }
        
        public int ObtenerAñosGarantia(int PrecioLista,DateTime FechaIngreso)
        {
            DateTime FechaAcomparar = new DateTime(DateTime.Now.Year, 1, 1);
            
            if (PrecioLista >= 9000)
            {
                return 1;
            }else if (DateTime.Compare(FechaIngreso, FechaAcomparar)>0)
            {
                return 3;
            }else
            {
                return 2;
            }            
        }

        public virtual int ObtenerPorcentajeDescuento(int Codigo)
        {
            return 0;
        }
    }
}

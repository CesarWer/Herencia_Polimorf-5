using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_polimorf_5
{
    internal class Venta
    {
        public int CodigoFactura { get; set; }
        public int CuilCliente { get; set; }
        public List<int> ProductosVendidos { get; set; }
        public DateTime FechaVenta { get; set; }
        public int ImporteTotal { get; set; }
        public string FormaPago { get; set; }

        public double ImporteFinal;
        public void ObtenerImporteFinal(int ImporteTotal,string FormaPago)
        {
            FormaPago.ToLower();
            if (FormaPago == "efectivo")
            {
                ImporteFinal = ImporteTotal - (ImporteTotal * 0.1);
            } 
            else if (FormaPago == "credito de la casa")
            {
                ImporteFinal = ImporteTotal + (ImporteTotal * 0.1);
            }
            else
            {
                ImporteFinal = ImporteTotal - (ImporteTotal * 0.05);
            }                 
            
        }     

    }
}

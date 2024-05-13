using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13_Repaso_2doParcial
{
    public class Productos
    {
        public string CodigoProducto { get; set; }
        public string NombreProudcto { get; set; }
        public string Descripcion { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }

        public Productos()
        {
            CodigoProducto = string.Empty;
            NombreProudcto = string.Empty;
            Descripcion = string.Empty;
            PrecioCompra = 0;
            PrecioVenta = 0;
        }
    }
}

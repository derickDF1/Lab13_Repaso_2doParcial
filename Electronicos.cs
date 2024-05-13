using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13_Repaso_2doParcial
{
    public class Electronicos : Productos
    {
        public string TiempoGarantia { get; set; }
        public string Voltaje { get; set; }

        public Electronicos()
        {
            TiempoGarantia = string.Empty;
            Voltaje = string.Empty;
        }

    }
}

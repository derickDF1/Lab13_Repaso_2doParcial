using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13_Repaso_2doParcial
{
    public class Alimentos : Productos
    {
        public DateTime FechaVencimiento { get; set; }
        public double unidadMedida { get; set; }

        public Alimentos()
        {
            FechaVencimiento = DateTime.Now;
            unidadMedida = 0;
        }
    }
}

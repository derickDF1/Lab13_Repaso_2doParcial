using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13_Repaso_2doParcial
{
    public class Libros : Productos
    {
        public string Editorial { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }

        public Libros()
        {
            Editorial = string.Empty;
            Categoria = string.Empty;
            Autor = string.Empty;
        }
    }
}

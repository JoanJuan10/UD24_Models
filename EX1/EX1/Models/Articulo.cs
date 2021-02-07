using System;
using System.Collections.Generic;

namespace EX1.Models
{
    public partial class Articulo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int IDFabricante { get; set; }

        public virtual Fabricante Fabricante { get; set; }
    }
}

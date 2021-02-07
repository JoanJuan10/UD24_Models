using System;
using System.Collections.Generic;

namespace EX1.Models
{
    public partial class Fabricante
    {
        public Fabricante()
        {
            Articulos = new HashSet<Articulo>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }

    }
}

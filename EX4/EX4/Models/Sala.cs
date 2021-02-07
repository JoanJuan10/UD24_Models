using System;
using System.Collections.Generic;

namespace EX4.Models
{
    public partial class Sala
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int IDPelicula { get; set; }

        public virtual Pelicula Pelicula { get; set; }
    }
}

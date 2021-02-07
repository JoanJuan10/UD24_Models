using System;
using System.Collections.Generic;

namespace EX4.Models
{
    public partial class Pelicula
    {
        public Pelicula()
        {
            Salas = new HashSet<Sala>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int CalificacionEdad { get; set; }
        public virtual ICollection<Sala> Salas { get; set; }

    }
}

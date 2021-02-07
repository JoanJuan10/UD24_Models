using System;
using System.Collections.Generic;

namespace EX3.Models
{
    public partial class Almacen
    {
        public Almacen()
        {
            Cajas = new HashSet<Caja>();
        }

        public int Codigo { get; set; }
        public string Lugar { get; set; }
        public int Capacidad { get; set; }
        public virtual ICollection<Caja> Cajas { get; set; }

    }
}

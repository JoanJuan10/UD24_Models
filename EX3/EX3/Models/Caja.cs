using System;
using System.Collections.Generic;

namespace EX3.Models
{
    public partial class Caja
    {
        public int NumReferencia { get; set; }
        public string Contenido { get; set; }
        public int Valor { get; set; }
        public int IDAlmacen { get; set; }

        public virtual Almacen Almacen { get; set; }
    }
}

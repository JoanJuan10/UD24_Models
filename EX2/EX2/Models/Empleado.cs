using System;
using System.Collections.Generic;

namespace EX2.Models
{
    public partial class Empleado
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int IDDepartamento { get; set; }

        public virtual Departamento Departamento { get; set; }
    }
}

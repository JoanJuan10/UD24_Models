using System;
using System.Collections.Generic;

namespace EX2.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Presupuesto { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }

    }
}

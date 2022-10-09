using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class Departamento
    {
        public Departamento()
        {
            DireccionGenerals = new HashSet<DireccionGeneral>();
        }

        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; } = null!;

        public virtual ICollection<DireccionGeneral> DireccionGenerals { get; set; }
    }
}

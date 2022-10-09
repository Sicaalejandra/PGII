using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class Colonium
    {
        public Colonium()
        {
            DireccionGenerals = new HashSet<DireccionGeneral>();
        }

        public int IdColonia { get; set; }
        public string NombreColonia { get; set; } = null!;

        public virtual ICollection<DireccionGeneral> DireccionGenerals { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class Municipo
    {
        public Municipo()
        {
            DireccionGenerals = new HashSet<DireccionGeneral>();
        }

        public int IdMunicipio { get; set; }
        public string NombreMunicipio { get; set; } = null!;

        public virtual ICollection<DireccionGeneral> DireccionGenerals { get; set; }
    }
}

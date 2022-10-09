using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class CalleCanton
    {
        public CalleCanton()
        {
            DireccionGenerals = new HashSet<DireccionGeneral>();
        }

        public int IdCalle { get; set; }
        public string DescripcionCalle { get; set; } = null!;

        public virtual ICollection<DireccionGeneral> DireccionGenerals { get; set; }
    }
}

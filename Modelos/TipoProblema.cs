using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class TipoProblema
    {
        public TipoProblema()
        {
            TicketGenerals = new HashSet<TicketGeneral>();
        }

        public int IdTipo { get; set; }
        public string NombreTipo { get; set; } = null!;

        public virtual ICollection<TicketGeneral> TicketGenerals { get; set; }
    }
}

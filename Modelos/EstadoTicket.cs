using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class EstadoTicket
    {
        public EstadoTicket()
        {
            TicketGenerals = new HashSet<TicketGeneral>();
        }

        public int IdEstado { get; set; }
        public string NombreEstado { get; set; } = null!;

        public virtual ICollection<TicketGeneral> TicketGenerals { get; set; }
    }
}

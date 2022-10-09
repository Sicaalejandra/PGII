using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class TicketGeneral
    {
        public TicketGeneral()
        {
            TicketPersonas = new HashSet<TicketPersona>();
        }

        public string AsuntoTicket { get; set; } = null!;
        public string DescripcionTicket { get; set; } = null!;
        public string Adjunto { get; set; } = null!;
        public int IdTicket { get; set; }
        public int IdTipo { get; set; }
        public int IdEstado { get; set; }
        public int IdTienda { get; set; }

        public virtual EstadoTicket IdEstadoNavigation { get; set; } = null!;
        public virtual OrigenTicket IdTiendaNavigation { get; set; } = null!;
        public virtual TipoProblema IdTipoNavigation { get; set; } = null!;
        public virtual ICollection<TicketPersona> TicketPersonas { get; set; }
    }
}

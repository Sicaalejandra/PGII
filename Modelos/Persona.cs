using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class Persona
    {
        public Persona()
        {
            MensajesForos = new HashSet<MensajesForo>();
            TicketPersonas = new HashSet<TicketPersona>();
        }

        public int IdPersona { get; set; }
        public string PrimerNombre { get; set; } = null!;
        public string SegundoNombre { get; set; } = null!;
        public string PrimerApellido { get; set; } = null!;
        public string SegundoApellido { get; set; } = null!;
        public int IdTipopersona { get; set; }
        public int IdTelefono { get; set; }
        public string CorreoP { get; set; } = null!;

        public virtual Correo CorreoPNavigation { get; set; } = null!;
        public virtual Telefono IdTelefonoNavigation { get; set; } = null!;
        public virtual TipoPersona IdTipopersonaNavigation { get; set; } = null!;
        public virtual ICollection<MensajesForo> MensajesForos { get; set; }
        public virtual ICollection<TicketPersona> TicketPersonas { get; set; }
    }
}

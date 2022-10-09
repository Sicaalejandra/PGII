using System;
using System.Collections.Generic;

namespace PGII.Modelos
{
    public partial class MensajesForo
    {
        public int IdMensaje { get; set; }
        public string DescripcionQueja { get; set; } = null!;
        public int IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; } = null!;
    }
}

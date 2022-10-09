using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PGII.Modelos
{
    public partial class PGIIContext : DbContext
    {
        public PGIIContext()
        {
        }

        public PGIIContext(DbContextOptions<PGIIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CalleCanton> CalleCantons { get; set; } = null!;
        public virtual DbSet<Colonium> Colonia { get; set; } = null!;
        public virtual DbSet<Correo> Correos { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<DireccionGeneral> DireccionGenerals { get; set; } = null!;
        public virtual DbSet<EstadoTicket> EstadoTickets { get; set; } = null!;
        public virtual DbSet<GrupoSoporte> GrupoSoportes { get; set; } = null!;
        public virtual DbSet<MensajesForo> MensajesForos { get; set; } = null!;
        public virtual DbSet<Municipo> Municipos { get; set; } = null!;
        public virtual DbSet<OrigenTicket> OrigenTickets { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Telefono> Telefonos { get; set; } = null!;
        public virtual DbSet<TicketGeneral> TicketGenerals { get; set; } = null!;
        public virtual DbSet<TicketPersona> TicketPersonas { get; set; } = null!;
        public virtual DbSet<TipoPersona> TipoPersonas { get; set; } = null!;
        public virtual DbSet<TipoProblema> TipoProblemas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("SQL"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CalleCanton>(entity =>
            {
                entity.HasKey(e => e.IdCalle)
                    .HasName("PK__Calle_ca__C031D088BD605DC4");

                entity.ToTable("Calle_canton");

                entity.Property(e => e.IdCalle)
                    .ValueGeneratedNever()
                    .HasColumnName("id_calle");

                entity.Property(e => e.DescripcionCalle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_Calle");
            });

            modelBuilder.Entity<Colonium>(entity =>
            {
                entity.HasKey(e => e.IdColonia)
                    .HasName("PK__Colonia__21BAACCD458421B6");

                entity.Property(e => e.IdColonia)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_colonia");

                entity.Property(e => e.NombreColonia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_colonia");
            });

            modelBuilder.Entity<Correo>(entity =>
            {
                entity.HasKey(e => e.CorreoP)
                    .HasName("PK__Correo__EA748BC9E80280CB");

                entity.ToTable("Correo");

                entity.Property(e => e.CorreoP)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_p");

                entity.Property(e => e.IdCorreo).HasColumnName("Id_correo");

                entity.Property(e => e.IdGrupo).HasColumnName("Id_grupo");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Correos)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Correo__Id_grupo__2E1BDC42");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento)
                    .HasName("PK__Departam__400D6B66E77D761A");

                entity.ToTable("Departamento");

                entity.Property(e => e.IdDepartamento)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_departamento");

                entity.Property(e => e.NombreDepartamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Departamento");
            });

            modelBuilder.Entity<DireccionGeneral>(entity =>
            {
                entity.HasKey(e => e.IdDireccion)
                    .HasName("PK__direccio__25C35D0770E2A4F0");

                entity.ToTable("direccion_general");

                entity.Property(e => e.IdDireccion)
                    .ValueGeneratedNever()
                    .HasColumnName("id_direccion");

                entity.Property(e => e.IdCalle).HasColumnName("id_calle");

                entity.Property(e => e.IdColonia).HasColumnName("Id_colonia");

                entity.Property(e => e.IdDepartamento).HasColumnName("Id_departamento");

                entity.Property(e => e.IdMunicipio).HasColumnName("id_municipio");

                entity.HasOne(d => d.IdCalleNavigation)
                    .WithMany(p => p.DireccionGenerals)
                    .HasForeignKey(d => d.IdCalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__direccion__id_ca__4316F928");

                entity.HasOne(d => d.IdColoniaNavigation)
                    .WithMany(p => p.DireccionGenerals)
                    .HasForeignKey(d => d.IdColonia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__direccion__Id_co__4222D4EF");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.DireccionGenerals)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__direccion__Id_de__403A8C7D");

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.DireccionGenerals)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__direccion__id_mu__412EB0B6");
            });

            modelBuilder.Entity<EstadoTicket>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__Estado_t__86989FB275BB7CF1");

                entity.ToTable("Estado_ticket");

                entity.Property(e => e.IdEstado)
                    .ValueGeneratedNever()
                    .HasColumnName("id_estado");

                entity.Property(e => e.NombreEstado)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre_estado");
            });

            modelBuilder.Entity<GrupoSoporte>(entity =>
            {
                entity.HasKey(e => e.IdGrupo)
                    .HasName("PK__Grupo_so__82882CA89FDA9405");

                entity.ToTable("Grupo_soporte");

                entity.Property(e => e.IdGrupo)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_grupo");

                entity.Property(e => e.DescripcionGrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Descripcion_grupo");
            });

            modelBuilder.Entity<MensajesForo>(entity =>
            {
                entity.HasKey(e => e.IdMensaje)
                    .HasName("PK__Mensajes__B192DF84EB4E5EDC");

                entity.ToTable("Mensajes_foro");

                entity.Property(e => e.IdMensaje)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_mensaje");

                entity.Property(e => e.DescripcionQueja)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Descripcion_queja");

                entity.Property(e => e.IdPersona).HasColumnName("Id_persona");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.MensajesForos)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mensajes___Id_pe__3D5E1FD2");
            });

            modelBuilder.Entity<Municipo>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio)
                    .HasName("PK__Municipo__01C9EB99AB05D69D");

                entity.ToTable("Municipo");

                entity.Property(e => e.IdMunicipio)
                    .ValueGeneratedNever()
                    .HasColumnName("id_municipio");

                entity.Property(e => e.NombreMunicipio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_municipio");
            });

            modelBuilder.Entity<OrigenTicket>(entity =>
            {
                entity.HasKey(e => e.IdTienda)
                    .HasName("PK__origen_t__7C49D736143B4833");

                entity.ToTable("origen_ticket");

                entity.Property(e => e.IdTienda)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tienda");

                entity.Property(e => e.IdDireccion).HasColumnName("id_direccion");

                entity.Property(e => e.NombreTienda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_tienda");

                entity.HasOne(d => d.IdDireccionNavigation)
                    .WithMany(p => p.OrigenTickets)
                    .HasForeignKey(d => d.IdDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__origen_ti__id_di__45F365D3");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Persona__13DCD245F514CB32");

                entity.ToTable("Persona");

                entity.Property(e => e.IdPersona)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_persona");

                entity.Property(e => e.CorreoP)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_p");

                entity.Property(e => e.IdTelefono).HasColumnName("id_telefono");

                entity.Property(e => e.IdTipopersona).HasColumnName("Id_tipopersona");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primer_apellido");

                entity.Property(e => e.PrimerNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primer_nombre");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundo_apellido");

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundo_nombre");

                entity.HasOne(d => d.CorreoPNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.CorreoP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__correo___3A81B327");

                entity.HasOne(d => d.IdTelefonoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdTelefono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__id_tele__398D8EEE");

                entity.HasOne(d => d.IdTipopersonaNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdTipopersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__Id_tipo__38996AB5");
            });

            modelBuilder.Entity<Telefono>(entity =>
            {
                entity.HasKey(e => e.IdTelefono)
                    .HasName("PK__Telefono__28CD680263222672");

                entity.ToTable("Telefono");

                entity.Property(e => e.IdTelefono)
                    .ValueGeneratedNever()
                    .HasColumnName("id_telefono");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.TipoTelefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo_telefono");
            });

            modelBuilder.Entity<TicketGeneral>(entity =>
            {
                entity.HasKey(e => e.IdTicket)
                    .HasName("PK__ticket_g__1CE744B640F9917D");

                entity.ToTable("ticket_general");

                entity.Property(e => e.IdTicket)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_ticket");

                entity.Property(e => e.Adjunto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adjunto")
                    .IsFixedLength();

                entity.Property(e => e.AsuntoTicket)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("asunto_ticket");

                entity.Property(e => e.DescripcionTicket)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_ticket");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdTienda).HasColumnName("id_tienda");

                entity.Property(e => e.IdTipo).HasColumnName("Id_tipo");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TicketGenerals)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ticket_ge__id_es__49C3F6B7");

                entity.HasOne(d => d.IdTiendaNavigation)
                    .WithMany(p => p.TicketGenerals)
                    .HasForeignKey(d => d.IdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ticket_ge__id_ti__4AB81AF0");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.TicketGenerals)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ticket_ge__Id_ti__48CFD27E");
            });

            modelBuilder.Entity<TicketPersona>(entity =>
            {
                entity.HasKey(e => e.NoTicket)
                    .HasName("PK__Ticket_p__39ECE5CC8B0AFE0C");

                entity.ToTable("Ticket_persona");

                entity.Property(e => e.NoTicket)
                    .ValueGeneratedNever()
                    .HasColumnName("No_ticket");

                entity.Property(e => e.IdPersona).HasColumnName("Id_persona");

                entity.Property(e => e.IdTicket).HasColumnName("Id_ticket");

                entity.Property(e => e.IdTipopersona).HasColumnName("Id_tipopersona");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.TicketPersonas)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ticket_pe__Id_pe__4E88ABD4");

                entity.HasOne(d => d.IdTicketNavigation)
                    .WithMany(p => p.TicketPersonas)
                    .HasForeignKey(d => d.IdTicket)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ticket_pe__Id_ti__4D94879B");

                entity.HasOne(d => d.IdTipopersonaNavigation)
                    .WithMany(p => p.TicketPersonas)
                    .HasForeignKey(d => d.IdTipopersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ticket_pe__Id_ti__4F7CD00D");
            });

            modelBuilder.Entity<TipoPersona>(entity =>
            {
                entity.HasKey(e => e.IdTipopersona)
                    .HasName("PK__Tipo_per__513764332BC77B49");

                entity.ToTable("Tipo_persona");

                entity.Property(e => e.IdTipopersona)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_tipopersona");

                entity.Property(e => e.TipoPersona1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_persona");
            });

            modelBuilder.Entity<TipoProblema>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__Tipo_pro__70A6B7E795FCE0DD");

                entity.ToTable("Tipo_problema");

                entity.Property(e => e.IdTipo)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_tipo");

                entity.Property(e => e.NombreTipo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre_tipo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

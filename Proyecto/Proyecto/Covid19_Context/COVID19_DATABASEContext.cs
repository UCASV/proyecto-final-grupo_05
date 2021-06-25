using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto.Covid19_Context
{
    public partial class COVID19_DATABASEContext : DbContext
    {
        public COVID19_DATABASEContext()
        {
        }

        public COVID19_DATABASEContext(DbContextOptions<COVID19_DATABASEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabina> Cabinas { get; set; }
        public virtual DbSet<Citum> Cita { get; set; }
        public virtual DbSet<Ciudadano> Ciudadanos { get; set; }
        public virtual DbSet<EfectoSecundario> EfectoSecundarios { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Enfermedad> Enfermedads { get; set; }
        public virtual DbSet<Lugar> Lugars { get; set; }
        public virtual DbSet<Tipo> Tipos { get; set; }
        public virtual DbSet<Vacunacion> Vacunacions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=COVID19_DATABASE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cabina>(entity =>
            {
                entity.ToTable("CABINA");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Citum>(entity =>
            {
                entity.ToTable("CITA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_hora");

                entity.Property(e => e.IdCiudadano)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_ciudadano");

                entity.Property(e => e.IdLugar).HasColumnName("id_lugar");

                entity.Property(e => e.IdentificadorCita).HasColumnName("identificador_cita");

                entity.Property(e => e.IdentificadorEmpleado).HasColumnName("identificador_empleado");

                entity.HasOne(d => d.IdCiudadanoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
<<<<<<< HEAD
                    .HasConstraintName("FK__CITA__id_ciudada__54CB950F");
=======
                    .HasConstraintName("FK__CITA__id_ciudada__49C3F6B7");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136

                entity.HasOne(d => d.IdLugarNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdLugar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
<<<<<<< HEAD
                    .HasConstraintName("FK__CITA__id_lugar__53D770D6");
=======
                    .HasConstraintName("FK__CITA__id_lugar__48CFD27E");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136

                entity.HasOne(d => d.IdentificadorEmpleadoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdentificadorEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
<<<<<<< HEAD
                    .HasConstraintName("FK__CITA__identifica__52E34C9D");
=======
                    .HasConstraintName("FK__CITA__identifica__47DBAE45");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136
            });

            modelBuilder.Entity<Ciudadano>(entity =>
            {
                entity.HasKey(e => e.Dui)
<<<<<<< HEAD
                    .HasName("PK__CIUDADAN__D876F1BE3AFCA1D3");
=======
                    .HasName("PK__CIUDADAN__D876F1BE2CA710C8");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136

                entity.ToTable("CIUDADANO");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdentificadorEmpleado).HasColumnName("identificador_empleado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroIdentificador).HasColumnName("numero_identificador");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdentificadorEmpleadoNavigation)
                    .WithMany(p => p.Ciudadanos)
                    .HasForeignKey(d => d.IdentificadorEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
<<<<<<< HEAD
                    .HasConstraintName("FK__CIUDADANO__ident__55BFB948");
=======
                    .HasConstraintName("FK__CIUDADANO__ident__4AB81AF0");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136
            });

            modelBuilder.Entity<EfectoSecundario>(entity =>
            {
                entity.ToTable("EFECTO_SECUNDARIO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EfectoSecundario1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("efecto_secundario");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.Identificador)
<<<<<<< HEAD
                    .HasName("PK__EMPLEADO__C83612B1BCE4C490");
=======
                    .HasName("PK__EMPLEADO__C83612B1908C1635");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136

                entity.ToTable("EMPLEADO");

                entity.Property(e => e.Identificador)
                    .ValueGeneratedNever()
                    .HasColumnName("identificador");

                entity.Property(e => e.Contrasenia)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("contrasenia");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FechaHoraRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_hora_registro");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdCabina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
<<<<<<< HEAD
                    .HasConstraintName("FK__EMPLEADO__id_cab__51EF2864");
=======
                    .HasConstraintName("FK__EMPLEADO__id_cab__46E78A0C");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
<<<<<<< HEAD
                    .HasConstraintName("FK__EMPLEADO__id_tip__50FB042B");
=======
                    .HasConstraintName("FK__EMPLEADO__id_tip__45F365D3");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136
            });

            modelBuilder.Entity<Enfermedad>(entity =>
            {
                entity.ToTable("ENFERMEDAD");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enfermedad1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enfermedad");

                entity.Property(e => e.IdCiudadano)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_ciudadano");

                entity.HasOne(d => d.IdCiudadanoNavigation)
                    .WithMany(p => p.Enfermedads)
                    .HasForeignKey(d => d.IdCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
<<<<<<< HEAD
                    .HasConstraintName("FK__ENFERMEDA__id_ci__57A801BA");
=======
                    .HasConstraintName("FK__ENFERMEDA__id_ci__4CA06362");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136
            });

            modelBuilder.Entity<Lugar>(entity =>
            {
                entity.ToTable("LUGAR");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Lugar1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lugar");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.ToTable("TIPO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Tipo1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<Vacunacion>(entity =>
            {
                entity.ToTable("VACUNACION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaHoraEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_hora_entrada");

                entity.Property(e => e.FechaHoraSalida)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_hora_salida");

                entity.Property(e => e.IdCiudadano)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_ciudadano");

                entity.Property(e => e.IdEfectoSecundario).HasColumnName("id_efecto_secundario");

                entity.Property(e => e.Tiempo).HasColumnName("tiempo");

                entity.HasOne(d => d.IdCiudadanoNavigation)
                    .WithMany(p => p.Vacunacions)
                    .HasForeignKey(d => d.IdCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
<<<<<<< HEAD
                    .HasConstraintName("FK__VACUNACIO__id_ci__56B3DD81");
=======
                    .HasConstraintName("FK__VACUNACIO__id_ci__4BAC3F29");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136

                entity.HasOne(d => d.IdEfectoSecundarioNavigation)
                    .WithMany(p => p.Vacunacions)
                    .HasForeignKey(d => d.IdEfectoSecundario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
<<<<<<< HEAD
                    .HasConstraintName("FK__VACUNACIO__id_ef__589C25F3");
=======
                    .HasConstraintName("FK__VACUNACIO__id_ef__4D94879B");
>>>>>>> e9d0e961cb3b68fed8ee2281ffa8b859f7035136
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

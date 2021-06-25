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
        public virtual DbSet<Empleadoxhistorial> Empleadoxhistorials { get; set; }
        public virtual DbSet<Enfermedad> Enfermedads { get; set; }
        public virtual DbSet<Historial> Historials { get; set; }
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

                entity.Property(e => e.Id).HasColumnName("id");

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
                    .HasConstraintName("FK__CITA__id_ciudada__5070F446");

                entity.HasOne(d => d.IdLugarNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdLugar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA__id_lugar__4F7CD00D");

                entity.HasOne(d => d.IdentificadorEmpleadoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdentificadorEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA__identifica__4E88ABD4");
            });

            modelBuilder.Entity<Ciudadano>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CIUDADAN__D876F1BED5EFCC07");

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
                    .HasConstraintName("FK__CIUDADANO__ident__5165187F");
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
                    .HasName("PK__EMPLEADO__C83612B16653B343");

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
                    .HasConstraintName("FK__EMPLEADO__id_cab__4BAC3F29");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLEADO__id_tip__49C3F6B7");
            });

            modelBuilder.Entity<Empleadoxhistorial>(entity =>
            {
                entity.ToTable("EMPLEADOXHISTORIAL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.IdHistorial).HasColumnName("id_historial");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Empleadoxhistorials)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLEADOX__id_em__4CA06362");

                entity.HasOne(d => d.IdHistorialNavigation)
                    .WithMany(p => p.Empleadoxhistorials)
                    .HasForeignKey(d => d.IdHistorial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLEADOX__id_hi__4D94879B");
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
                    .HasConstraintName("FK__ENFERMEDA__id_ci__534D60F1");
            });

            modelBuilder.Entity<Historial>(entity =>
            {
                entity.ToTable("HISTORIAL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_hora");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.Historials)
                    .HasForeignKey(d => d.IdCabina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HISTORIAL__id_ca__4AB81AF0");
            });

            modelBuilder.Entity<Lugar>(entity =>
            {
                entity.ToTable("LUGAR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lugar1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lugar");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.ToTable("TIPO");

                entity.Property(e => e.Id).HasColumnName("id");

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
                    .HasConstraintName("FK__VACUNACIO__id_ci__52593CB8");

                entity.HasOne(d => d.IdEfectoSecundarioNavigation)
                    .WithMany(p => p.Vacunacions)
                    .HasForeignKey(d => d.IdEfectoSecundario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACUNACIO__id_ef__5441852A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

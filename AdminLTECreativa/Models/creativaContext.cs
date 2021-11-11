using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AdminLTECreativa.Models
{
    public partial class creativaContext : DbContext
    {
        public creativaContext()
        {
        }

        public creativaContext(DbContextOptions<creativaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Solicitude> Solicitudes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Port=5432;Host=localhost;Database=creativa;Username=postgres;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Spanish_El Salvador.1252");

            modelBuilder.Entity<Solicitude>(entity =>
            {
                entity.ToTable("solicitudes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(25)
                    .HasColumnName("cargo");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .HasColumnName("dui");

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .HasColumnName("email");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Fechaaprob)
                    .HasMaxLength(20)
                    .HasColumnName("fechaaprob");

                entity.Property(e => e.Fechaborrado)
                    .HasMaxLength(20)
                    .HasColumnName("fechaborrado");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(25)
                    .HasColumnName("lastname");

                entity.Property(e => e.Mes)
                    .HasMaxLength(20)
                    .HasColumnName("mes");

                entity.Property(e => e.Mesdesc)
                    .HasMaxLength(20)
                    .HasColumnName("mesdesc");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .HasColumnName("name");

                entity.Property(e => e.Tiposolicitud)
                    .HasMaxLength(25)
                    .HasColumnName("tiposolicitud");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("email");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("lastname");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .HasColumnName("password");

                entity.Property(e => e.Repassword)
                    .HasMaxLength(25)
                    .HasColumnName("repassword");

                entity.Property(e => e.Rol)
                    .HasMaxLength(1)
                    .HasColumnName("rol");

                entity.Property(e => e.Tokenrecovery)
                    .HasMaxLength(200)
                    .HasColumnName("tokenrecovery");

                entity.Property(e => e.Userr)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("userr");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Laborario_01.Models
{
    public partial class Db_Context : DbContext
    {
        public Db_Context()
        {
        }

        public Db_Context(DbContextOptions<Db_Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TAlumno> TAlumnos { get; set; }
        public virtual DbSet<TProducto> TProductos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=ec2-18-214-238-28.compute-1.amazonaws.com;Database=d2c7b6nlti8tt5;Username=ijhewcsloxhdvc;Password=3861f2f1e5b1a4873246c66556021af1629d67c49980f61d568833566f01bbb9;Port=5432;SSL Mode=Require;Trust Server Certificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<TAlumno>(entity =>
            {
                entity.HasKey(e => e.PkEalumno)
                    .HasName("t_alumno_pkey");

                entity.ToTable("t_alumno");

                entity.Property(e => e.PkEalumno).HasColumnName("pk_ealumno");

                entity.Property(e => e.Bgenero)
                    .HasColumnType("bit(1)")
                    .HasColumnName("bgenero");

                entity.Property(e => e.Capellido)
                    .HasMaxLength(250)
                    .HasColumnName("capellido");

                entity.Property(e => e.Ccarrera)
                    .HasMaxLength(100)
                    .HasColumnName("ccarrera");

                entity.Property(e => e.Cdni)
                    .HasMaxLength(8)
                    .HasColumnName("cdni");

                entity.Property(e => e.Cnombre)
                    .HasMaxLength(100)
                    .HasColumnName("cnombre");

                entity.Property(e => e.Ffechanacimiento)
                    .HasColumnType("date")
                    .HasColumnName("ffechanacimiento");
            });

            modelBuilder.Entity<TProducto>(entity =>
            {
                entity.HasKey(e => e.PkEproducto)
                    .HasName("t_producto_pkey");

                entity.ToTable("t_producto");

                entity.Property(e => e.PkEproducto).HasColumnName("pk_eproducto");

                entity.Property(e => e.Categoria)
                    .HasColumnType("character varying")
                    .HasColumnName("categoria");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.Nombre)
                    .HasColumnType("character varying")
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

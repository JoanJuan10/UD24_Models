using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EX3.Models
{
    public partial class APIContext : DbContext
    {
        
        public APIContext(DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Caja> Caja { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.ToTable("Almacenes");

                entity.Property(e => e.Codigo).HasColumnName("Codigo")
                    .UseIdentityColumn();

                entity.Property(e => e.Lugar)
                    .HasColumnName("Lugar")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Capacidad).HasColumnName("Capacidad");

                entity.HasKey(e => e.Codigo);
            });

            modelBuilder.Entity<Caja>(entity =>
            {
                entity.ToTable("Cajas");

                entity.Property(e => e.NumReferencia)
                    .HasColumnName("NumReferencia")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Contenido)
                    .HasColumnName("Contenido")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasKey(e => e.NumReferencia);

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.Cajas)
                    .HasForeignKey(d => d.IDAlmacen);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

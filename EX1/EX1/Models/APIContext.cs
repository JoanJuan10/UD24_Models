using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EX1.Models
{
    public partial class APIContext : DbContext
    {
        
        public APIContext(DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Fabricante> Fabricante { get; set; }
        public virtual DbSet<Articulo> Articulo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fabricante>(entity =>
            {
                entity.ToTable("Fabricantes");

                entity.Property(e => e.Codigo).HasColumnName("Codigo")
                    .UseIdentityColumn();

                entity.Property(e => e.Nombre)
                    .HasColumnName("Nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasKey(e => e.Codigo);
            });

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.ToTable("Articulos");

                entity.Property(e => e.Codigo).HasColumnName("Codigo")
                    .UseIdentityColumn();

                entity.Property(e => e.Nombre)
                    .HasColumnName("Nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Precio).HasColumnName("Precio")
                    .HasColumnType("int");

                entity.HasKey(e => e.Codigo);

                entity.HasOne(d => d.Fabricante)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.IDFabricante);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

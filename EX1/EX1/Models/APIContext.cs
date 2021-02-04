using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EX1.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base (options)
        {

        }
        public virtual DbSet<Articulo> Articulos { get; set; }
        public virtual DbSet<Fabricante> Fabricantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fabricante>(entity =>
            {
                entity.ToTable("Fabricantes");
                entity.HasKey(c => c.Codigo);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

            });
            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.ToTable("Articulos");
                entity.HasKey(c => c.Codigo);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnType("int");

                entity.HasOne(d => d.Fabricante)
                .WithMany(p => p.Articulos)
                .HasForeignKey(d => d.Codigo)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

        }
    }
}

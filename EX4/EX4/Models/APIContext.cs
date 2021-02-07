using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EX4.Models
{
    public partial class APIContext : DbContext
    {
        
        public APIContext(DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pelicula> Pelicula { get; set; }
        public virtual DbSet<Sala> Sala { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelicula>(entity =>
            {
                entity.ToTable("Peliculas");

                entity.Property(e => e.Codigo).HasColumnName("Codigo")
                    .UseIdentityColumn();

                entity.Property(e => e.Nombre)
                    .HasColumnName("Nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CalificacionEdad).HasColumnName("CalificacionEdad");

                entity.HasKey(e => e.Codigo);
            });

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.ToTable("Salas");

                entity.Property(e => e.Codigo).HasColumnName("Codigo")
                    .UseIdentityColumn();

                entity.Property(e => e.Nombre)
                    .HasColumnName("Nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasKey(e => e.Codigo);

                entity.HasOne(d => d.Pelicula)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.IDPelicula);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

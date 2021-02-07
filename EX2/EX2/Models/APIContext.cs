using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EX2.Models
{
    public partial class APIContext : DbContext
    {
        
        public APIContext(DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("Departamentos");

                entity.Property(e => e.Codigo).HasColumnName("Codigo")
                    .UseIdentityColumn();

                entity.Property(e => e.Nombre)
                    .HasColumnName("Nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Presupuesto).HasColumnName("Presupuesto");

                entity.HasKey(e => e.Codigo);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("Empleados");

                entity.Property(e => e.DNI)
                    .HasColumnName("DNI")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("Nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Apellidos)
                    .HasColumnName("Apellidos")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasKey(e => e.DNI);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IDDepartamento);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

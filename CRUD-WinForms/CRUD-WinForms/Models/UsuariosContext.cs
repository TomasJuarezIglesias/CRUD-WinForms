using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUD_WinForms.Models;

public partial class UsuariosContext : DbContext
{
    public UsuariosContext()
    {
    }

    public UsuariosContext(DbContextOptions<UsuariosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=TOMASJUAREZ; Database=Usuarios; User=soporte; Password=123; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Dni);

            entity.Property(e => e.Dni)
                .ValueGeneratedNever()
                .HasColumnName("DNI");
            entity.Property(e => e.Apellido).HasMaxLength(20);
            entity.Property(e => e.FechaNacimiento).HasColumnType("date");
            entity.Property(e => e.Nombre).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

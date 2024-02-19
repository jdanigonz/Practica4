using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Practica4.Models;

public partial class PersonalContext : DbContext
{
    public PersonalContext()
    {
    }

    public PersonalContext(DbContextOptions<PersonalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("server=localhost; database=personal; integrated security=true; Encrypt=False; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuario__3214EC0786494A2D");

            entity.ToTable("usuario");

            entity.Property(e => e.CarnetIdentidad).HasMaxLength(15);
            entity.Property(e => e.Celular).HasMaxLength(15);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

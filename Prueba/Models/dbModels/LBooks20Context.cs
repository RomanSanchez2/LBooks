using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Prueba.Models.dbModels
{
    public partial class LBooks20Context : IdentityDbContext<ApplicationUser,IdentityRole<int>,int>
    {
        public LBooks20Context()
        {
        }

        public LBooks20Context(DbContextOptions<LBooks20Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autors { get; set; } = null!;
        public virtual DbSet<Genero> Generos { get; set; } = null!;
        public virtual DbSet<Libro> Libros { get; set; } = null!;
        public virtual DbSet<Reseña> Reseñas { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.Property(e => e.IdAutor).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.Property(e => e.IdGenero).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.Property(e => e.IdLibro).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdAutorNavigation)
                    .WithMany(p => p.Libros)
                    .HasForeignKey(d => d.IdAutor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LIBRO_AUTOR");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Libros)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LIBRO_GENERO");
            });

            modelBuilder.Entity<Reseña>(entity =>
            {
                entity.Property(e => e.IdReseñas).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdLibroNavigation)
                    .WithMany(p => p.Reseñas)
                    .HasForeignKey(d => d.IdLibro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESEÑAS_LIBRO");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Reseñas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESEÑAS_USUARIO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba.Models.dbModels;

#nullable disable

namespace Prueba.Migrations
{
    [DbContext(typeof(LBooks20Context))]
    [Migration("20230601020846_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Prueba.Models.dbModels.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Prueba.Models.dbModels.Autor", b =>
                {
                    b.Property<int>("IdAutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID AUTOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAutor"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOMBRE");

                    b.HasKey("IdAutor");

                    b.ToTable("AUTOR");
                });

            modelBuilder.Entity("Prueba.Models.dbModels.Genero", b =>
                {
                    b.Property<int>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID GENERO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGenero"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DESCRIPCION");

                    b.HasKey("IdGenero");

                    b.ToTable("GENERO");
                });

            modelBuilder.Entity("Prueba.Models.dbModels.Libro", b =>
                {
                    b.Property<int>("IdLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID LIBRO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLibro"), 1L, 1);

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CONTENIDO");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime")
                        .HasColumnName("FECHA");

                    b.Property<int>("IdAutor")
                        .HasColumnType("int")
                        .HasColumnName("ID AUTOR");

                    b.Property<int>("IdGenero")
                        .HasColumnType("int")
                        .HasColumnName("ID GENERO");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IMAGEN");

                    b.Property<int>("Paginas")
                        .HasColumnType("int")
                        .HasColumnName("PAGINAS");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TITULO");

                    b.HasKey("IdLibro");

                    b.HasIndex("IdAutor");

                    b.HasIndex("IdGenero");

                    b.ToTable("LIBRO");
                });

            modelBuilder.Entity("Prueba.Models.dbModels.Reseña", b =>
                {
                    b.Property<int>("IdReseñas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID RESEÑAS");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReseñas"), 1L, 1);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime")
                        .HasColumnName("FECHA");

                    b.Property<int>("IdLibro")
                        .HasColumnType("int")
                        .HasColumnName("ID  LIBRO");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("ID USUARIO");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TITULO");

                    b.HasKey("IdReseñas");

                    b.HasIndex("IdLibro");

                    b.HasIndex("IdUsuario");

                    b.ToTable("RESEÑAS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Prueba.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Prueba.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prueba.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Prueba.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prueba.Models.dbModels.Libro", b =>
                {
                    b.HasOne("Prueba.Models.dbModels.Autor", "IdAutorNavigation")
                        .WithMany("Libros")
                        .HasForeignKey("IdAutor")
                        .IsRequired()
                        .HasConstraintName("FK_LIBRO_AUTOR");

                    b.HasOne("Prueba.Models.dbModels.Genero", "IdGeneroNavigation")
                        .WithMany("Libros")
                        .HasForeignKey("IdGenero")
                        .IsRequired()
                        .HasConstraintName("FK_LIBRO_GENERO");

                    b.Navigation("IdAutorNavigation");

                    b.Navigation("IdGeneroNavigation");
                });

            modelBuilder.Entity("Prueba.Models.dbModels.Reseña", b =>
                {
                    b.HasOne("Prueba.Models.dbModels.Libro", "IdLibroNavigation")
                        .WithMany("Reseñas")
                        .HasForeignKey("IdLibro")
                        .IsRequired()
                        .HasConstraintName("FK_RESEÑAS_LIBRO");

                    b.HasOne("Prueba.Models.dbModels.ApplicationUser", "IdUsuarioNavigation")
                        .WithMany("Reseñas")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_RESEÑAS_USUARIO");

                    b.Navigation("IdLibroNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("Prueba.Models.dbModels.ApplicationUser", b =>
                {
                    b.Navigation("Reseñas");
                });

            modelBuilder.Entity("Prueba.Models.dbModels.Autor", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("Prueba.Models.dbModels.Genero", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("Prueba.Models.dbModels.Libro", b =>
                {
                    b.Navigation("Reseñas");
                });
#pragma warning restore 612, 618
        }
    }
}
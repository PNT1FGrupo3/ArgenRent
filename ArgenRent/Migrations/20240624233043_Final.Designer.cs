﻿// <auto-generated />
using System;
using ArgenRent.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArgenRent.Migrations
{
    [DbContext(typeof(ArgenRentDatabaseContext))]
    [Migration("20240624233043_Final")]
    partial class Final
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArgenRent.Models.Alquiler", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("PropiedadId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaSalida")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("PropiedadId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Alquileres");
                });

            modelBuilder.Entity("ArgenRent.Models.Direccion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("altura")
                        .HasColumnType("int");

                    b.Property<string>("calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("localidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("piso")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("ArgenRent.Models.Propiedad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<bool>("aceptaMascotas")
                        .HasColumnType("bit");

                    b.Property<int>("cantidadAmbientes")
                        .HasColumnType("int");

                    b.Property<int>("cantidadBanios")
                        .HasColumnType("int");

                    b.Property<int>("cantidadCocheras")
                        .HasColumnType("int");

                    b.Property<int>("cantidadDormitorios")
                        .HasColumnType("int");

                    b.Property<int>("cantidadM2Cubiertos")
                        .HasColumnType("int");

                    b.Property<int>("cantidadM2Descubiertos")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precioPorNoche")
                        .HasColumnType("float");

                    b.Property<double>("ranking")
                        .HasColumnType("float");

                    b.Property<int>("tipoPropiedad")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Propiedades");
                });

            modelBuilder.Entity("ArgenRent.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("rating")
                        .HasColumnType("float");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ArgenRent.Models.Alquiler", b =>
                {
                    b.HasOne("ArgenRent.Models.Propiedad", "propiedad")
                        .WithMany()
                        .HasForeignKey("PropiedadId");

                    b.HasOne("ArgenRent.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("propiedad");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("ArgenRent.Models.Propiedad", b =>
                {
                    b.HasOne("ArgenRent.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("usuario");
                });
#pragma warning restore 612, 618
        }
    }
}

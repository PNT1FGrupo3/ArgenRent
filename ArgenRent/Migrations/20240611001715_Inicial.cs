using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArgenRent.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altura = table.Column<int>(type: "int", nullable: false),
                    piso = table.Column<int>(type: "int", nullable: false),
                    departamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    localidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pais = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Propiedades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precioPorNoche = table.Column<double>(type: "float", nullable: false),
                    aceptaMascotas = table.Column<bool>(type: "bit", nullable: false),
                    cantidadAmbientes = table.Column<int>(type: "int", nullable: false),
                    cantidadDormitorios = table.Column<int>(type: "int", nullable: false),
                    cantidadBanios = table.Column<int>(type: "int", nullable: false),
                    cantidadM2Cubiertos = table.Column<int>(type: "int", nullable: false),
                    cantidadM2Descubiertos = table.Column<int>(type: "int", nullable: false),
                    cantidadCocheras = table.Column<int>(type: "int", nullable: false),
                    ranking = table.Column<double>(type: "float", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    DireccionId = table.Column<int>(type: "int", nullable: true),
                    tipoPropiedad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Propiedades_Direcciones_DireccionId",
                        column: x => x.DireccionId,
                        principalTable: "Direcciones",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Propiedades_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Alquileres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PropiedadId = table.Column<int>(type: "int", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquileres", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Alquileres_Propiedades_PropiedadId",
                        column: x => x.PropiedadId,
                        principalTable: "Propiedades",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Alquileres_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_PropiedadId",
                table: "Alquileres",
                column: "PropiedadId");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_UsuarioId",
                table: "Alquileres",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_DireccionId",
                table: "Propiedades",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_UsuarioId",
                table: "Propiedades",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alquileres");

            migrationBuilder.DropTable(
                name: "Propiedades");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}

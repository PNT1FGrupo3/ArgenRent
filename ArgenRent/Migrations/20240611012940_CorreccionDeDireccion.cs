using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArgenRent.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionDeDireccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_Direcciones_DireccionId",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_DireccionId",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "DireccionId",
                table: "Propiedades");

            migrationBuilder.AddColumn<string>(
                name: "direccion",
                table: "Propiedades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "direccion",
                table: "Propiedades");

            migrationBuilder.AddColumn<int>(
                name: "DireccionId",
                table: "Propiedades",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_DireccionId",
                table: "Propiedades",
                column: "DireccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_Direcciones_DireccionId",
                table: "Propiedades",
                column: "DireccionId",
                principalTable: "Direcciones",
                principalColumn: "ID");
        }
    }
}

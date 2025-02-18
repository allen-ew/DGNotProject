using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DgNotification.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEstadoNotificacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notificada",
                table: "Notificacion");

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Notificacion",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Medicamento",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "Compra",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Cliente",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Notificacion");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Medicamento");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Cliente");

            migrationBuilder.AddColumn<bool>(
                name: "Notificada",
                table: "Notificacion",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "PrecioUnitario",
                table: "Compra",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}

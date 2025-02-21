using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DgNotification.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Cliente_ClienteId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Medicamento_MedicamentoId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentoFrecuencia_Cliente_ClienteId",
                table: "MedicamentoFrecuencia");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentoFrecuencia_Medicamento_MedicamentoId",
                table: "MedicamentoFrecuencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificacion_Cliente_ClienteId",
                table: "Notificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificacion_Medicamento_MedicamentoId",
                table: "Notificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notificacion",
                table: "Notificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicamentoFrecuencia",
                table: "MedicamentoFrecuencia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicamento",
                table: "Medicamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Compra",
                table: "Compra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Notificacion",
                newName: "Notificaciones");

            migrationBuilder.RenameTable(
                name: "MedicamentoFrecuencia",
                newName: "MedicamentoFrecuencias");

            migrationBuilder.RenameTable(
                name: "Medicamento",
                newName: "Medicamentos");

            migrationBuilder.RenameTable(
                name: "Compra",
                newName: "Compras");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_Notificacion_MedicamentoId",
                table: "Notificaciones",
                newName: "IX_Notificaciones_MedicamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Notificacion_ClienteId",
                table: "Notificaciones",
                newName: "IX_Notificaciones_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicamentoFrecuencia_MedicamentoId",
                table: "MedicamentoFrecuencias",
                newName: "IX_MedicamentoFrecuencias_MedicamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicamentoFrecuencia_ClienteId",
                table: "MedicamentoFrecuencias",
                newName: "IX_MedicamentoFrecuencias_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_MedicamentoId",
                table: "Compras",
                newName: "IX_Compras_MedicamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_ClienteId",
                table: "Compras",
                newName: "IX_Compras_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_Cedula",
                table: "Clientes",
                newName: "IX_Clientes_Cedula");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notificaciones",
                table: "Notificaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicamentoFrecuencias",
                table: "MedicamentoFrecuencias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicamentos",
                table: "Medicamentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compras",
                table: "Compras",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_ClienteId",
                table: "Compras",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Medicamentos_MedicamentoId",
                table: "Compras",
                column: "MedicamentoId",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentoFrecuencias_Clientes_ClienteId",
                table: "MedicamentoFrecuencias",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentoFrecuencias_Medicamentos_MedicamentoId",
                table: "MedicamentoFrecuencias",
                column: "MedicamentoId",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Clientes_ClienteId",
                table: "Notificaciones",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Medicamentos_MedicamentoId",
                table: "Notificaciones",
                column: "MedicamentoId",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_ClienteId",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Medicamentos_MedicamentoId",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentoFrecuencias_Clientes_ClienteId",
                table: "MedicamentoFrecuencias");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentoFrecuencias_Medicamentos_MedicamentoId",
                table: "MedicamentoFrecuencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_Clientes_ClienteId",
                table: "Notificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_Medicamentos_MedicamentoId",
                table: "Notificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notificaciones",
                table: "Notificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicamentos",
                table: "Medicamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicamentoFrecuencias",
                table: "MedicamentoFrecuencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Compras",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Notificaciones",
                newName: "Notificacion");

            migrationBuilder.RenameTable(
                name: "Medicamentos",
                newName: "Medicamento");

            migrationBuilder.RenameTable(
                name: "MedicamentoFrecuencias",
                newName: "MedicamentoFrecuencia");

            migrationBuilder.RenameTable(
                name: "Compras",
                newName: "Compra");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameIndex(
                name: "IX_Notificaciones_MedicamentoId",
                table: "Notificacion",
                newName: "IX_Notificacion_MedicamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Notificaciones_ClienteId",
                table: "Notificacion",
                newName: "IX_Notificacion_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicamentoFrecuencias_MedicamentoId",
                table: "MedicamentoFrecuencia",
                newName: "IX_MedicamentoFrecuencia_MedicamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicamentoFrecuencias_ClienteId",
                table: "MedicamentoFrecuencia",
                newName: "IX_MedicamentoFrecuencia_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Compras_MedicamentoId",
                table: "Compra",
                newName: "IX_Compra_MedicamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Compras_ClienteId",
                table: "Compra",
                newName: "IX_Compra_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_Cedula",
                table: "Cliente",
                newName: "IX_Cliente_Cedula");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notificacion",
                table: "Notificacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicamento",
                table: "Medicamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicamentoFrecuencia",
                table: "MedicamentoFrecuencia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compra",
                table: "Compra",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Cliente_ClienteId",
                table: "Compra",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Medicamento_MedicamentoId",
                table: "Compra",
                column: "MedicamentoId",
                principalTable: "Medicamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentoFrecuencia_Cliente_ClienteId",
                table: "MedicamentoFrecuencia",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentoFrecuencia_Medicamento_MedicamentoId",
                table: "MedicamentoFrecuencia",
                column: "MedicamentoId",
                principalTable: "Medicamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificacion_Cliente_ClienteId",
                table: "Notificacion",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificacion_Medicamento_MedicamentoId",
                table: "Notificacion",
                column: "MedicamentoId",
                principalTable: "Medicamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

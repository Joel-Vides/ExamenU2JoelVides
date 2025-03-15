using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen2POO.API.Migrations
{
    /// <inheritdoc />
    public partial class AddPlanillasEmpleados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "planillas",
                table: "Empleados",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_planillas",
                table: "Empleados",
                column: "planillas");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Planillas_planillas",
                table: "Empleados",
                column: "planillas",
                principalTable: "Planillas",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Planillas_planillas",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_planillas",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "planillas",
                table: "Empleados");
        }
    }
}

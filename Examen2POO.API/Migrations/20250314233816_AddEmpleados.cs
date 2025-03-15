using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen2POO.API.Migrations
{
    /// <inheritdoc />
    public partial class AddEmpleados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    dni = table.Column<int>(type: "INTEGER", nullable: false),
                    first_name = table.Column<string>(type: "TEXT", nullable: false),
                    Last_name = table.Column<string>(type: "TEXT", nullable: false),
                    document = table.Column<string>(type: "TEXT", nullable: false),
                    hiring_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    departament = table.Column<string>(type: "TEXT", nullable: true),
                    puesto_trabajo = table.Column<string>(type: "TEXT", nullable: true),
                    base_salary = table.Column<decimal>(type: "TEXT", nullable: false),
                    active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoEmcartago.Server.Migrations
{
    public partial class FormatoEntregaEpp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "formatoEntregaEpp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Funcionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Registro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oficina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isdelete = table.Column<bool>(type: "bit", nullable: false),
                    GA = table.Column<bool>(type: "bit", nullable: false),
                    CA = table.Column<bool>(type: "bit", nullable: false),
                    GU = table.Column<bool>(type: "bit", nullable: false),
                    BS = table.Column<bool>(type: "bit", nullable: false),
                    CHS = table.Column<bool>(type: "bit", nullable: false),
                    TO = table.Column<bool>(type: "bit", nullable: false),
                    TB = table.Column<bool>(type: "bit", nullable: false),
                    IMP = table.Column<bool>(type: "bit", nullable: false),
                    EPG = table.Column<bool>(type: "bit", nullable: false),
                    AMD = table.Column<bool>(type: "bit", nullable: false),
                    LVV = table.Column<bool>(type: "bit", nullable: false),
                    AR = table.Column<bool>(type: "bit", nullable: false),
                    EA = table.Column<bool>(type: "bit", nullable: false),
                    M = table.Column<bool>(type: "bit", nullable: false),
                    O = table.Column<bool>(type: "bit", nullable: false),
                    F = table.Column<bool>(type: "bit", nullable: false),
                    Otro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formatoEntregaEpp", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "formatoEntregaEpp");
        }
    }
}

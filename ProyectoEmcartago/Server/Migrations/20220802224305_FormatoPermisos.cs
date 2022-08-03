using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoEmcartago.Server.Migrations
{
    public partial class FormatoPermisos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "formatoPermisos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oficina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Formato = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Causa_Del_Permiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Causa_Del_Permiso_Otros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Desde = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Hasta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Autoriza_Jefe_Inmediato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autoriza_SubGerentes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formatoPermisos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "formatoPermisos");
        }
    }
}

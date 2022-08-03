using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoEmcartago.Server.Migrations
{
    public partial class usoepp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inspeccionUsoEpp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Responsable_Inspeccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Casco_De_Seguridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Casco_De_Seguridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guantes_Tipo_Ingeniero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Guantes_Tipo_Ingeniero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guantes_De_Caucho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Guantes_De_Caucho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guantes_Carnaza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Guantes_Carnaza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gafas_De_Seguridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Gafas_De_Seguridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gafas_De_Seguridad_lente_Oscuro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Gafas_De_Seguridad_lente_Oscuro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Careta_De_Seguridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Careta_De_Seguridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mascarilla_Con_Filtros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Mascarilla_Con_Filtros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tapa_Bocas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Tapa_Bocas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Protector_Auditivo_Insercion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Protector_Auditivo_Insercion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Protector_Auditivo_De_Copa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Protector_Auditivo_De_Copa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chaleco_Reflectivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Chaleco_Reflectivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Impermeable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Impermeable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Otros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Otro_Elemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Otros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pantalon_Reflectivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Pantalon_Reflectivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Camisa_Con_Reflectivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Camisa_Con_Reflectivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Botas_De_Seguridad_Con_Puntera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Botas_De_Seguridad_Con_Puntera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Botas_De_Caucho_Con_Puntera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Botas_De_Caucho_Con_Puntera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Botas_De_Seguridad_Sin_Puntera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Botas_De_Seguridad_Sin_Puntera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gorra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Gorra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seguridad_Social = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Seguridad_Social = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carnet_De_Contratista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Carnet_De_Contratista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Epps_De_Acuerdo_A_La_Actividad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Epps_De_Acuerdo_A_La_Actividad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trabajo_En_Alturas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Curso_Trabajo_En_Alturas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Trabajo_En_Alturas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disposicion_De_Los_Epps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opcion_Disposicion_De_Los_Epps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Disposicion_De_Los_Epps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sitio_Coordinador_Para_Trabajo_En_Alturas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_Coordinador_En_Alturas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Sitio_Coordinador_Para_Trabajo_En_Alturas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actividad_Mayor_O_Igual_A_15_Dias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion_Actividad_Mayor_O_Igual_A_15_Dias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inspeccionUsoEpp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Imagenes_UsoEpp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InspeccionUsoEppId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagenes_UsoEpp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagenes_UsoEpp_inspeccionUsoEpp_InspeccionUsoEppId",
                        column: x => x.InspeccionUsoEppId,
                        principalTable: "inspeccionUsoEpp",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "inspeccionUsoEpp",
                columns: new[] { "Id", "Actividad_Mayor_O_Igual_A_15_Dias", "Botas_De_Caucho_Con_Puntera", "Botas_De_Seguridad_Con_Puntera", "Botas_De_Seguridad_Sin_Puntera", "Camisa_Con_Reflectivo", "Careta_De_Seguridad", "Cargo", "Carnet_De_Contratista", "Casco_De_Seguridad", "Chaleco_Reflectivo", "Curso_Trabajo_En_Alturas", "Disposicion_De_Los_Epps", "Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista", "Epps_De_Acuerdo_A_La_Actividad", "Fecha", "Gafas_De_Seguridad", "Gafas_De_Seguridad_lente_Oscuro", "Gorra", "Guantes_Carnaza", "Guantes_De_Caucho", "Guantes_Tipo_Ingeniero", "ImageUrl", "Impermeable", "IsDelete", "Mascarilla_Con_Filtros", "Nombre", "Nombre_Coordinador_En_Alturas", "Observacion_Actividad_Mayor_O_Igual_A_15_Dias", "Observacion_Botas_De_Caucho_Con_Puntera", "Observacion_Botas_De_Seguridad_Con_Puntera", "Observacion_Botas_De_Seguridad_Sin_Puntera", "Observacion_Camisa_Con_Reflectivo", "Observacion_Careta_De_Seguridad", "Observacion_Carnet_De_Contratista", "Observacion_Casco_De_Seguridad", "Observacion_Chaleco_Reflectivo", "Observacion_Disposicion_De_Los_Epps", "Observacion_Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista", "Observacion_Epps_De_Acuerdo_A_La_Actividad", "Observacion_Gafas_De_Seguridad", "Observacion_Gafas_De_Seguridad_lente_Oscuro", "Observacion_Gorra", "Observacion_Guantes_Carnaza", "Observacion_Guantes_De_Caucho", "Observacion_Guantes_Tipo_Ingeniero", "Observacion_Impermeable", "Observacion_Mascarilla_Con_Filtros", "Observacion_Otros", "Observacion_Pantalon_Reflectivo", "Observacion_Protector_Auditivo_De_Copa", "Observacion_Protector_Auditivo_Insercion", "Observacion_Seguridad_Social", "Observacion_Sitio_Coordinador_Para_Trabajo_En_Alturas", "Observacion_Tapa_Bocas", "Observacion_Trabajo_En_Alturas", "Opcion_Disposicion_De_Los_Epps", "Otro_Elemento", "Otros", "Pantalon_Reflectivo", "Protector_Auditivo_De_Copa", "Protector_Auditivo_Insercion", "Responsable_Inspeccion", "Seguridad_Social", "Sitio_Coordinador_Para_Trabajo_En_Alturas", "Tapa_Bocas", "Trabajo_En_Alturas" },
                values: new object[] { 1, "No Aplica", "No Cumple", "No Cumple", "No Cumple", "No Cumple", "Cumple", "Funcionario", "No Aplica", "Cumple", "Cumple", "Avanzado", "No Aplica", "No Aplica", "No Aplica", new DateTime(2022, 8, 3, 10, 7, 41, 102, DateTimeKind.Local).AddTicks(3409), "Cumple", "Cumple", "No Cumple", "Cumple", "Cumple", "Cumple", "", "Cumple", false, "Cumple", "Juan Manuel Ramirez Hernandez", "Javier Boneti", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Proteccion Contra Caidas", "Casco de tres dimensiones", "Cumple", "No Cumple", "Cumple", "Cumple", "Luis Alfredo Bolívar González", "No Aplica", "No Aplica", "Cumple", "No Aplica" });

            migrationBuilder.CreateIndex(
                name: "IX_Imagenes_UsoEpp_InspeccionUsoEppId",
                table: "Imagenes_UsoEpp",
                column: "InspeccionUsoEppId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imagenes_UsoEpp");

            migrationBuilder.DropTable(
                name: "inspeccionUsoEpp");
        }
    }
}

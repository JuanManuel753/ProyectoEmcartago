using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoEmcartago.Server.Migrations
{
    public partial class IngresoySalida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "inspeccionUsoEpp",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "IngresoySalidaEquiposComputo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dependencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lugar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_salida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_entrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Codigo_bien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_serie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Persona_que_se_Autoriza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jefe_que_Autoriza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mantenimiento_y_o_Reparacion = table.Column<bool>(type: "bit", nullable: false),
                    Prestamo = table.Column<bool>(type: "bit", nullable: false),
                    Devolucion = table.Column<bool>(type: "bit", nullable: false),
                    De_su_propiedad = table.Column<bool>(type: "bit", nullable: false),
                    Tranferencia = table.Column<bool>(type: "bit", nullable: false),
                    Despacho = table.Column<bool>(type: "bit", nullable: false),
                    Realizar_trabajo = table.Column<bool>(type: "bit", nullable: false),
                    Otros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solicitado_por = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_Solicitado_por = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora_Solicitado_por = table.Column<TimeSpan>(type: "time", nullable: false),
                    Autorizado_por = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_Autorizado_por = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora_Autorizado_por = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresoySalidaEquiposComputo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngresoySalidaEquiposComputo");

            migrationBuilder.InsertData(
                table: "inspeccionUsoEpp",
                columns: new[] { "Id", "Actividad_Mayor_O_Igual_A_15_Dias", "Botas_De_Caucho_Con_Puntera", "Botas_De_Seguridad_Con_Puntera", "Botas_De_Seguridad_Sin_Puntera", "Camisa_Con_Reflectivo", "Careta_De_Seguridad", "Cargo", "Carnet_De_Contratista", "Casco_De_Seguridad", "Chaleco_Reflectivo", "Curso_Trabajo_En_Alturas", "Disposicion_De_Los_Epps", "Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista", "Epps_De_Acuerdo_A_La_Actividad", "Fecha", "Gafas_De_Seguridad", "Gafas_De_Seguridad_lente_Oscuro", "Gorra", "Guantes_Carnaza", "Guantes_De_Caucho", "Guantes_Tipo_Ingeniero", "ImageUrl", "Impermeable", "IsDelete", "Mascarilla_Con_Filtros", "Nombre", "Nombre_Coordinador_En_Alturas", "Observacion_Actividad_Mayor_O_Igual_A_15_Dias", "Observacion_Botas_De_Caucho_Con_Puntera", "Observacion_Botas_De_Seguridad_Con_Puntera", "Observacion_Botas_De_Seguridad_Sin_Puntera", "Observacion_Camisa_Con_Reflectivo", "Observacion_Careta_De_Seguridad", "Observacion_Carnet_De_Contratista", "Observacion_Casco_De_Seguridad", "Observacion_Chaleco_Reflectivo", "Observacion_Disposicion_De_Los_Epps", "Observacion_Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista", "Observacion_Epps_De_Acuerdo_A_La_Actividad", "Observacion_Gafas_De_Seguridad", "Observacion_Gafas_De_Seguridad_lente_Oscuro", "Observacion_Gorra", "Observacion_Guantes_Carnaza", "Observacion_Guantes_De_Caucho", "Observacion_Guantes_Tipo_Ingeniero", "Observacion_Impermeable", "Observacion_Mascarilla_Con_Filtros", "Observacion_Otros", "Observacion_Pantalon_Reflectivo", "Observacion_Protector_Auditivo_De_Copa", "Observacion_Protector_Auditivo_Insercion", "Observacion_Seguridad_Social", "Observacion_Sitio_Coordinador_Para_Trabajo_En_Alturas", "Observacion_Tapa_Bocas", "Observacion_Trabajo_En_Alturas", "Opcion_Disposicion_De_Los_Epps", "Otro_Elemento", "Otros", "Pantalon_Reflectivo", "Protector_Auditivo_De_Copa", "Protector_Auditivo_Insercion", "Responsable_Inspeccion", "Seguridad_Social", "Sitio_Coordinador_Para_Trabajo_En_Alturas", "Tapa_Bocas", "Trabajo_En_Alturas" },
                values: new object[] { 1, "No Aplica", "No Cumple", "No Cumple", "No Cumple", "No Cumple", "Cumple", "Funcionario", "No Aplica", "Cumple", "Cumple", "Avanzado", "No Aplica", "No Aplica", "No Aplica", new DateTime(2022, 8, 3, 10, 7, 41, 102, DateTimeKind.Local).AddTicks(3409), "Cumple", "Cumple", "No Cumple", "Cumple", "Cumple", "Cumple", "", "Cumple", false, "Cumple", "Juan Manuel Ramirez Hernandez", "Javier Boneti", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Funcionario Cumplidor con esta medida", "Proteccion Contra Caidas", "Casco de tres dimensiones", "Cumple", "No Cumple", "Cumple", "Cumple", "Luis Alfredo Bolívar González", "No Aplica", "No Aplica", "Cumple", "No Aplica" });
        }
    }
}

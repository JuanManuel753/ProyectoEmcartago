﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoEmcartago.Server.Migrations
{
    public partial class PEDSYP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PEDSYP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa_Vehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dependencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Revision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Conductor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isdelete = table.Column<bool>(type: "bit", nullable: false),
                    licencia_de_conduccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    licencia_de_conduccion_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarjeta_de_propiedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarjeta_de_propiedad_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vencimiento_TP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Soat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soat_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vencimiento_S = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tecno_mecanica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tecno_mecanica_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vencimiento_TM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Puertas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puertas_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manijas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manijas_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silla_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Espejos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Espejos_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tablero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tablero_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parabrisas_Ventanas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parabrisas_Ventanas_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinturon_Seguridad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinturon_Seguridad_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sist_Comunicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sist_Comunicacion_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altas_y_bajas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altas_y_bajas_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tracera_de_trabajo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tracera_de_trabajo_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccionales_delanteras_p = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccionales_delanteras_p_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccionales_traseras_p = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccionales_traseras_p_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stop_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estroboscopicas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estroboscopicas_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luces_reversa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luces_reversa_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcionamiento_pito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcionamiento_pito_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcionamiento_alarma_y_camara = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcionamiento_alarma_y_camara_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ajustes_bornes_bateria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ajustes_bornes_bateria_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tapas_bateria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tapas_bateria_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_de_frenos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_de_frenos_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revisión_practica_frenos_transmision_y_embrague = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revisión_practica_frenos_transmision_y_embrague_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drenar_tanques_aire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drenar_tanques_aire_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revise_el_sistema_del_secador_de_aire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revise_el_sistema_del_secador_de_aire_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_de_freno_de_ahogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_de_freno_de_ahogo_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ruido_motor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ruido_motor_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_y_tensión_de_correas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_y_tensión_de_correas_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sin_fugas_de_fluidos_por_mangueras_accesorios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sin_fugas_de_fluidos_por_mangueras_accesorios_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_aceite_de_motor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_aceite_de_motor_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_aceite_de_direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_aceite_de_direccion_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_aceite_de_caja_velocidades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_aceite_de_caja_velocidades_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_aceite_de_transmision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_aceite_de_transmision_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_aceite_de_ruedas_delanteras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_aceite_de_ruedas_delanteras_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_de_refrigerante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_de_refrigerante_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_de_limpiabrisas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel_de_limpiabrisas_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drenarfiltro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drenarfiltro_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estad_presencia_de_tapa_sin_goteo_fugas_TC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estad_presencia_de_tapa_sin_goteo_fugas_TC_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verificar_nivel_conexion_electrica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verificar_nivel_conexion_electrica_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estad_presencia_de_tapa_sin_goteo_fugas_TU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estad_presencia_de_tapa_sin_goteo_fugas_TU_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_ajuste_tapa_filtros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_ajuste_tapa_filtros_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_abullamientos_cortes_desgastes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_abullamientos_cortes_desgastes_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precion_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bomba_hidráulica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bomba_hidráulica_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mangueras_tubos_conexiones_racores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mangueras_tubos_conexiones_racores_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cilindros_de_levante_del_brazo_del_boom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cilindros_de_levante_del_brazo_del_boom_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cilindros_de_movimientos_laterales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cilindros_de_movimientos_laterales_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cilindro_de_extension_del_brazo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cilindro_de_extension_del_brazo_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EGCCCSFLPI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EGCCCSFLPI_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_Manguera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_Manguera_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_Verificar_cantidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_Verificar_cantidad_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revision_verificar_de_tamiz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revision_verificar_de_tamiz_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verificacion_de_nivel_aceite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verificacion_de_nivel_aceite_observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDSYP", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PEDSYP");
        }
    }
}

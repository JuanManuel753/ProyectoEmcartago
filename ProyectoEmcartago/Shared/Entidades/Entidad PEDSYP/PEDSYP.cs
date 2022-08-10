using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmcartago.Shared.Entidades.Entidad_PEDSYP
{
    public class PEDSYP
    {
        //Informacion principal para el registro
        public int Id { get; set; }

        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? Placa_Vehiculo { get; set; }

        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? Dependencia { get; set; }


        public DateTime Fecha_Revision { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? Conductor { get; set; }

        public bool Isdelete { get; set; }

        //Revision de Documentacion
        //DOCUMENTOS

        public string? licencia_de_conduccion { get; set; }

        public string? licencia_de_conduccion_observacion { get; set; }

        //--------------------------------------------
        public string? Tarjeta_de_propiedad { get; set; }

        public string? Tarjeta_de_propiedad_observacion { get; set; }
        public DateTime Vencimiento_TP { get; set; } = DateTime.Now;

        //--------------------------------------------
        public string? Soat { get; set; }

        public string? Soat_observacion { get; set; }
        public DateTime Vencimiento_S { get; set; } = DateTime.Now;

        //--------------------------------------------
        public string? Tecno_mecanica { get; set; }

        public string? Tecno_mecanica_observacion { get; set; }
        public DateTime Vencimiento_TM { get; set; } = DateTime.Now;

        //--------------------------------------------

        //CABINA

        public string? Puertas { get; set; }
        public string? Puertas_observacion { get; set; }


        public string? Manijas { get; set; }
        public string? Manijas_observacion { get; set; }


        public string? Silla { get; set; }
        public string? Silla_observacion { get; set; }


        public string? Espejos { get; set; }
        public string? Espejos_observacion { get; set; }


        public string? Tablero { get; set; }
        public string? Tablero_observacion { get; set; }


        public string? Parabrisas_Ventanas { get; set; }
        public string? Parabrisas_Ventanas_observacion { get; set; }


        public string? Cinturon_Seguridad { get; set; }
        public string? Cinturon_Seguridad_observacion { get; set; }


        public string? Sist_Comunicacion { get; set; }
        public string? Sist_Comunicacion_observacion { get; set; }

        //--------------------------------------------

        //SISTEMA ELECTICO
        //Luces
        public string? Altas_y_bajas { get; set; }
        public string? Altas_y_bajas_observacion { get; set; }


        public string? Tracera_de_trabajo { get; set; }
        public string? Tracera_de_trabajo_observacion { get; set; }


        public string? Direccionales_delanteras_p { get; set; }
        public string? Direccionales_delanteras_p_observacion { get; set; }


        public string? Direccionales_traseras_p { get; set; }
        public string? Direccionales_traseras_p_observacion { get; set; }


        public string? Stop { get; set; }
        public string? Stop_observacion { get; set; }


        public string? Estroboscopicas { get; set; }
        public string? Estroboscopicas_observacion { get; set; }


        public string? Luces_reversa { get; set; }
        public string? Luces_reversa_observacion { get; set; }

        //Pito
        public string? Funcionamiento_pito { get; set; }
        public string? Funcionamiento_pito_observacion { get; set; }

        //Alarma de retoceso
        public string? Funcionamiento_alarma_y_camara { get; set; }
        public string? Funcionamiento_alarma_y_camara_observacion { get; set; }

        //Bateria
        public string? Ajustes_bornes_bateria { get; set; }
        public string? Ajustes_bornes_bateria_observacion { get; set; }


        public string? Tapas_bateria { get; set; }
        public string? Tapas_bateria_observacion { get; set; }

        //SISTEMA TECNICO- MECANICO
        //frenos
        public string? Estado_de_frenos { get; set; }
        public string? Estado_de_frenos_observacion { get; set; }


        public string? Revisión_practica_frenos_transmision_y_embrague { get; set; }
        public string? Revisión_practica_frenos_transmision_y_embrague_observacion { get; set; }


        public string? Drenar_tanques_aire { get; set; }
        public string? Drenar_tanques_aire_observacion { get; set; }


        public string? Revise_el_sistema_del_secador_de_aire { get; set; }
        public string? Revise_el_sistema_del_secador_de_aire_observacion { get; set; }


        public string? Estado_de_freno_de_ahogo { get; set; }
        public string? Estado_de_freno_de_ahogo_observacion { get; set; }

        //Motor
        public string? Ruido_motor { get; set; }
        public string? Ruido_motor_observacion { get; set; }


        public string? Estado_y_tensión_de_correas { get; set; }
        public string? Estado_y_tensión_de_correas_observacion { get; set; }


        public string? Sin_fugas_de_fluidos_por_mangueras_accesorios { get; set; }
        public string? Sin_fugas_de_fluidos_por_mangueras_accesorios_observacion { get; set; }

        //Nivel de fluidos
        public string? Nivel_aceite_de_motor { get; set; }
        public string? Nivel_aceite_de_motor_observacion { get; set; }


        public string? Nivel_aceite_de_direccion { get; set; }
        public string? Nivel_aceite_de_direccion_observacion { get; set; }


        public string? Nivel_aceite_de_caja_velocidades { get; set; }
        public string? Nivel_aceite_de_caja_velocidades_observacion { get; set; }


        public string? Nivel_aceite_de_transmision { get; set; }
        public string? Nivel_aceite_de_transmision_observacion { get; set; }


        public string? Nivel_aceite_de_ruedas_delanteras { get; set; }
        public string? Nivel_aceite_de_ruedas_delanteras_observacion { get; set; }


        public string? Nivel_de_refrigerante { get; set; }
        public string? Nivel_de_refrigerante_observacion { get; set; }


        public string? Nivel_de_limpiabrisas { get; set; }
        public string? Nivel_de_limpiabrisas_observacion { get; set; }

        //Tanque de combustible
        public string? Drenarfiltro { get; set; }
        public string? Drenarfiltro_observacion { get; set; }


        public string? Estad_presencia_de_tapa_sin_goteo_fugas_TC { get; set; }
        public string? Estad_presencia_de_tapa_sin_goteo_fugas_TC_observacion { get; set; }

        //Tanque de urea
        public string? Verificar_nivel_conexion_electrica { get; set; }
        public string? Verificar_nivel_conexion_electrica_observacion { get; set; }


        public string? Estad_presencia_de_tapa_sin_goteo_fugas_TU { get; set; }
        public string? Estad_presencia_de_tapa_sin_goteo_fugas_TU_observacion { get; set; }


        //Filtros
        public string? Estado_ajuste_tapa_filtros { get; set; }
        public string? Estado_ajuste_tapa_filtros_observacion { get; set; }


        //Llantas
        public string? Estado_abullamientos_cortes_desgastes { get; set; }
        public string? Estado_abullamientos_cortes_desgastes_observacion { get; set; }


        public string? Precion { get; set; }
        public string? Precion_observacion { get; set; }
        //--------------------------------------------

        //SUCCION
        //Sistema hidraulico Brazo del Boom
        public string? Bomba_hidráulica { get; set; }
        public string? Bomba_hidráulica_observacion { get; set; }


        public string? Mangueras_tubos_conexiones_racores { get; set; }
        public string? Mangueras_tubos_conexiones_racores_observacion { get; set; }


        public string? Cilindros_de_levante_del_brazo_del_boom { get; set; }
        public string? Cilindros_de_levante_del_brazo_del_boom_observacion { get; set; }


        public string? Cilindros_de_movimientos_laterales { get; set; }
        public string? Cilindros_de_movimientos_laterales_observacion { get; set; }


        public string? Cilindro_de_extension_del_brazo { get; set; }
        public string? Cilindro_de_extension_del_brazo_observacion { get; set; }
        //--------------------------------------------
        //Controles
        //Estado general de controles en cabina, carretel
        //Senunles frontal, laterales y pantalla intelliview
        public string? EGCCCSFLPI { get; set; }
        public string? EGCCCSFLPI_observacion { get; set; }


        //Manguera de succión
        public string? Estado_Manguera { get; set; }
        public string? Estado_Manguera_observacion { get; set; }

        //Tuveria de succión
        public string? Estado_Verificar_cantidad { get; set; }
        public string? Estado_Verificar_cantidad_observacion { get; set; }

        //Bomba de desplazamiento positivo
        public string? Revision_verificar_de_tamiz { get; set; }
        public string? Revision_verificar_de_tamiz_observacion { get; set; }


        public string? Verificacion_de_nivel_aceite { get; set; }
        public string? Verificacion_de_nivel_aceite_observacion { get; set; }
    }
}

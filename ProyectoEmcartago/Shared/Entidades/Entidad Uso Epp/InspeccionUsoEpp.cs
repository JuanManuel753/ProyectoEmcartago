using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmcartago.Shared.Entidades.Entidad_Uso_Epp
{
    public class InspeccionUsoEpp
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
        public List<Imagen_UsoEpp> Imagenes_UsoEpp { get; set; } = new List<Imagen_UsoEpp>();
        [Required(ErrorMessage = "Es Necesario El Nombre Del Funcionario")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es Necesario  El Cargo Del Funcionario")]
        public string Cargo { get; set; } = string.Empty;


        public DateTime Fecha { get; set; } = DateTime.Now;


        [Required(ErrorMessage = "Es Necesario El Responsable De Inspeccion")]
        public string Responsable_Inspeccion { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Casco_De_Seguridad { get; set; } = string.Empty;
        public string Observacion_Casco_De_Seguridad { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Guantes_Tipo_Ingeniero { get; set; } = string.Empty;
        public string Observacion_Guantes_Tipo_Ingeniero { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Guantes_De_Caucho { get; set; } = string.Empty;
        public string Observacion_Guantes_De_Caucho { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Guantes_Carnaza { get; set; } = string.Empty;
        public string Observacion_Guantes_Carnaza { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Gafas_De_Seguridad { get; set; } = string.Empty;
        public string Observacion_Gafas_De_Seguridad { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Gafas_De_Seguridad_lente_Oscuro { get; set; } = string.Empty;
        public string Observacion_Gafas_De_Seguridad_lente_Oscuro { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Careta_De_Seguridad { get; set; } = string.Empty;
        public string Observacion_Careta_De_Seguridad { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Mascarilla_Con_Filtros { get; set; } = string.Empty;
        public string Observacion_Mascarilla_Con_Filtros { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Tapa_Bocas { get; set; } = string.Empty;
        public string Observacion_Tapa_Bocas { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Protector_Auditivo_Insercion { get; set; } = string.Empty;
        public string Observacion_Protector_Auditivo_Insercion { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Protector_Auditivo_De_Copa { get; set; } = string.Empty;
        public string Observacion_Protector_Auditivo_De_Copa { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Chaleco_Reflectivo { get; set; } = string.Empty;
        public string Observacion_Chaleco_Reflectivo { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Impermeable { get; set; } = string.Empty;
        public string Observacion_Impermeable { get; set; } = string.Empty;


        public string Otros { get; set; } = string.Empty;
        public string Otro_Elemento { get; set; } = string.Empty;
        public string Observacion_Otros { get; set; } = string.Empty;



        //Dotacion
        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Pantalon_Reflectivo { get; set; } = string.Empty;
        public string Observacion_Pantalon_Reflectivo { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Camisa_Con_Reflectivo { get; set; } = string.Empty;
        public string Observacion_Camisa_Con_Reflectivo { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Botas_De_Seguridad_Con_Puntera { get; set; } = string.Empty;
        public string Observacion_Botas_De_Seguridad_Con_Puntera { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Botas_De_Caucho_Con_Puntera { get; set; } = string.Empty;
        public string Observacion_Botas_De_Caucho_Con_Puntera { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Botas_De_Seguridad_Sin_Puntera { get; set; } = string.Empty;
        public string Observacion_Botas_De_Seguridad_Sin_Puntera { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Gorra { get; set; } = string.Empty;
        public string Observacion_Gorra { get; set; } = string.Empty;


        //Contratista
        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Seguridad_Social { get; set; } = string.Empty;
        public string Observacion_Seguridad_Social { get; set; } = string.Empty;



        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista { get; set; } = string.Empty;
        public string Observacion_Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista { get; set; } = string.Empty;



        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Carnet_De_Contratista { get; set; } = string.Empty;
        public string Observacion_Carnet_De_Contratista { get; set; } = string.Empty;



        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Epps_De_Acuerdo_A_La_Actividad { get; set; } = string.Empty;
        public string Observacion_Epps_De_Acuerdo_A_La_Actividad { get; set; } = string.Empty;



        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Trabajo_En_Alturas { get; set; } = string.Empty;
        public string Curso_Trabajo_En_Alturas { get; set; } = string.Empty;
        public string Observacion_Trabajo_En_Alturas { get; set; } = string.Empty;



        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Disposicion_De_Los_Epps { get; set; } = string.Empty;
        public string Opcion_Disposicion_De_Los_Epps { get; set; } = string.Empty;
        public string Observacion_Disposicion_De_Los_Epps { get; set; } = string.Empty;


        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Sitio_Coordinador_Para_Trabajo_En_Alturas { get; set; } = string.Empty;
        public string Nombre_Coordinador_En_Alturas { get; set; } = string.Empty;
        public string Observacion_Sitio_Coordinador_Para_Trabajo_En_Alturas { get; set; } = string.Empty;



        [Required(ErrorMessage = "Es Necesario Seleccionar una Opcion")]
        public string Actividad_Mayor_O_Igual_A_15_Dias { get; set; } = string.Empty;
        public string Observacion_Actividad_Mayor_O_Igual_A_15_Dias { get; set; } = string.Empty;

        public bool IsDelete { get; set; } = false;
    }
}

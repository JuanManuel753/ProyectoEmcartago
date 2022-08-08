using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmcartago.Shared.Entidades.Entidad_Ingreso_y_Salida
{
    public class IngresoySalida
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Dependencia { get; set; }

        [RegularExpression("(^[A-Z a-z]+$)", ErrorMessage = "No se permiten tiles,comas,puntos o caracteres especiales( Ej : ´ , . ñ @ ) ")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Lugar { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime? Fecha_salida { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime? Fecha_entrada { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Codigo_bien { get; set; }

        [RegularExpression("(^[A-Z a-z]+$)", ErrorMessage = "No se permiten tiles,comas,puntos o caracteres especiales( Ej : ´ , . ñ @ )")]
        public string? Marca { get; set; }

        public string? Modelo { get; set; }
        public string? N_serie { get; set; }

        [RegularExpression("(^[A-Z a-z]+$)", ErrorMessage = "No se permiten tiles,comas,puntos o caracteres especiales( Ej : ´ , . ñ @ )")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Destino { get; set; }

        [RegularExpression("(^[A-Z a-z]+$)", ErrorMessage = "No se permiten tiles,comas,puntos o caracteres especiales( Ej : ´ , . ñ @ )")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Persona_que_se_Autoriza { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Jefe_que_Autoriza { get; set; }
        public bool Mantenimiento_y_o_Reparacion { get; set; }
        public bool Prestamo { get; set; }
        public bool Devolucion { get; set; }
        public bool De_su_propiedad { get; set; }
        public bool Tranferencia { get; set; }
        public bool Despacho { get; set; }
        public bool Realizar_trabajo { get; set; }
        public string? Otros { get; set; }

        [RegularExpression("(^[A-Z a-z]+$)", ErrorMessage = "No se permiten tiles,comas,puntos o caracteres especiales( Ej : ´ , . ñ @ )")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Solicitado_por { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime? fecha_Solicitado_por { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public TimeSpan? hora_Solicitado_por { get; set; }

        [RegularExpression("(^[A-Z a-z]+$)", ErrorMessage = "No se permiten tiles,comas,puntos o caracteres especiales( Ej : ´ , . ñ @ )( Ej : ´ , . ñ @ )")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Autorizado_por { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime? fecha_Autorizado_por { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public TimeSpan? hora_Autorizado_por { get; set; }

        public bool IsDelete { get; set; }
    }
}

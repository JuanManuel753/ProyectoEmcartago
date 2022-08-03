using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmcartago.Shared.Entidades.Entidad_Formato_De_Permisos
{
    public class FormatoPermisos
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Escribir El Nombre Del Funcionario Es Obligatorio")]
        public string Nombre { get; set; } = string.Empty;


        [Required(ErrorMessage = "Seleccionar La Oficina Es Obligatorio")]
        public string Oficina { get; set; } = string.Empty;


        [Required(ErrorMessage = "Escribir El Cargo Del Funcionario Es Obligatorio")]
        public string Cargo { get; set; } = string.Empty;


        [Required(AllowEmptyStrings = false, ErrorMessage = "Escribir La Cedula Es Obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo Se Permiten Números")]
        public string Cedula { get; set; } = string.Empty;


        public DateTime? Fecha_Formato { get; set; } = DateTime.Now;


        [Required(ErrorMessage = "Seleccionar La Causa Del Permiso Es Obligatorio")]
        public string Causa_Del_Permiso { get; set; } = string.Empty;


        public string Causa_Del_Permiso_Otros { get; set; } = string.Empty;


        [Required(ErrorMessage = "Colocar fecha es obligatorio")]
        public DateTime? Fecha_Desde { get; set; } = DateTime.Today;


        [Required(ErrorMessage = "Colocar fecha es obligatorio")]
        public DateTime? Fecha_Hasta { get; set; } = DateTime.Today;


        [Required(ErrorMessage = "Escribir El Nombre Del Jefe Inmediato Es Obligatorio")]
        public string Autoriza_Jefe_Inmediato { get; set; } = string.Empty;


        [Required(ErrorMessage = "Escribir El Nombre Del SubGerente Es Obligatorio")]
        public string Autoriza_SubGerentes { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }
    }
}

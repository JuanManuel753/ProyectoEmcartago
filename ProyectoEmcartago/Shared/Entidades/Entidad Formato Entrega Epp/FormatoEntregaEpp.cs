using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmcartago.Shared.Entidades.Entidad_Formato_Entrega_Epp
{
    public class FormatoEntregaEpp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre_Funcionario { get; set; } = string.Empty;

        public DateTime? Fecha_Registro { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cedula { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cargo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Oficina { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cantidad { get; set; } = string.Empty;

        public bool Isdelete { get; set; }




        //Elementos de Proteccion persona
        public bool GA { get; set; }
        public bool CA { get; set; }
        public bool GU { get; set; }
        public bool BS { get; set; }
        public bool CHS { get; set; }
        public bool TO { get; set; }
        public bool TB { get; set; }
        public bool IMP { get; set; }
        public bool EPG { get; set; }
        public bool AMD { get; set; }
        public bool LVV { get; set; }
        public bool AR { get; set; }
        public bool EA { get; set; }
        public bool M { get; set; }
        public bool O { get; set; }
        public bool F { get; set; }
        public string? Otro { get; set; }



        //Campo para Firma
        public string? Foto { get; set; } = string.Empty;
    }
}

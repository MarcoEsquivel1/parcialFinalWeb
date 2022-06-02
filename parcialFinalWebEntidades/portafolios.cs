using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebEntidades
{
    public class portafolios
    {
        [Key]
        public int idPortafolio { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre del proyecto")]
        [MinLength(3, ErrorMessage = "Ingrese un nombre de proyecto valido")]
        public string nombreProyecto { get; set; }
        [Required(ErrorMessage = "Debe ingresar el rol del proyecto")]
        [MinLength(3, ErrorMessage = "Ingrese un nombre de experiencia valido")]
        public string rol { get; set; }
        public string resumen { get; set; }
        public string responsabilidades { get; set; }
        public string tecnologiasUsadas { get; set; }
        [Required]
        public int idUsuario { get; set; }
    }
}

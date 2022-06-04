using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebEntidades
{
    public class habilidades
    {
        [Key]
        public int idHabilidad { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre de la habilidad")]
        [MinLength(3, ErrorMessage = "Ingrese un nombre de habilidad valido")]
        public string habilidad { get; set; }
        [Required(ErrorMessage = "Debe una calificación del 1-5")]
        [Range(1, 5, ErrorMessage = "Ingrese una calificacion del 1-5")]
        public int calificacion { get; set; }
        [Required]
        public int idUsuario { get; set; }
    }
}

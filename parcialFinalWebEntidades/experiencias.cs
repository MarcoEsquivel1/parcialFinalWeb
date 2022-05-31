using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebEntidades
{
    public class experiencias
    {
        [Key]
        public int idExperiencia { get; set; }
        [Required(ErrorMessage ="Debe ingresar el nombre de la experiencia")]
        [MinLength(3, ErrorMessage = "Ingrese un nombre de experiencia valido")]
        public string experiencia { get; set; }
        [Required(ErrorMessage = "Debe ingresar los años de experiencia")]
        [Range(1, 100, ErrorMessage = "Ingrese una cantidad de años valida")]
        public int anios { get; set; }
        [Required]
        public int idUsuario { get; set; }
    }
}

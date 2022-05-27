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
        [Required]
        public string habilidad { get; set; }
        [Required]
        public int calificacion { get; set; }
        [Required]
        public int idUsuario { get; set; }
    }
}

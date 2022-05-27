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
        [Required]
        public string experiencia { get; set; }
        [Required]
        public int anios { get; set; }
        [Required]
        public int idUsuario { get; set; }
    }
}

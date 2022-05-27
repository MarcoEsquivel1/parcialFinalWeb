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
        [Required]
        public string nombreProyecto { get; set; }
        [Required]
        public string rol { get; set; }
        public string resumen { get; set; }
        public string responsabilidades { get; set; }
        public string tecnologiasUsadas { get; set; }
        [Required]
        public int idUsuario { get; set; }
    }
}

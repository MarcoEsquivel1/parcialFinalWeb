using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebEntidades
{
    public class gradosacademicos
    {
        [Key]
        public int idGrado { get; set; }
        [Required]
        public string profesion { get; set; }
        [Required]
        public string universidad { get; set; }
        public string objetivo { get; set; }
        [Required]
        public int idUsuario { get; set; }
        [NotMapped]
        public usuarios usuario { get; set; }
    }
}

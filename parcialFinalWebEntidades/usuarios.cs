using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebEntidades
{
    public class usuarios
    {
        [Key]
        public int idUsuario { get; set; }
        [Required]
        public string username { get; set; }
        [MaxLength(300, ErrorMessage = "Link demasiado grande")]
        public string foto { get; set; }
        [Required]
        public string nombres { get; set; }
        [Required]
        public string apellidos { get; set; }
        [Required]
        public string correo { get; set; }
        public string introduccion { get; set; }
        [MaxLength(300, ErrorMessage = "Link demasiado grande")]
        public string linkedin { get; set; }
        [MaxLength(300, ErrorMessage = "Link demasiado grande")]
        public string facebook { get; set; }
        public string otro { get; set; }
        [NotMapped]
        public gradosacademicos grado { get; set; }
    }

   
}

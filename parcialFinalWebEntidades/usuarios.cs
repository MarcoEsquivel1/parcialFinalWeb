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
        [Required(ErrorMessage = "Debe ingresar el nombre de usuario")]
        public string username { get; set; }
        [MaxLength(300, ErrorMessage = "Link demasiado grande")]
        public string foto { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre")]
        public string nombres { get; set; }
        [Required(ErrorMessage = "Debe ingresar el apellido")]
        public string apellidos { get; set; }
        [Required(ErrorMessage = "Debe ingresar el correo")]
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

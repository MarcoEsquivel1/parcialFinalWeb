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
        public string foto { get; set; }
        [Required]
        public string nombres { get; set; }
        [Required]
        public string apellidos { get; set; }
        [Required]
        public string correo { get; set; }
        public string introduccion { get; set; }
        public string linkedin { get; set; }
        public string facebook { get; set; }
        public string otro { get; set; }
        [NotMapped]
        public gradoAcademico grado { get; set; }
    }

    [Keyless]
    public class gradoAcademico
    {
        public string profesion { get; set; }
        public string universidad { get; set; }
        public string objetivo { get; set; }

    }
}

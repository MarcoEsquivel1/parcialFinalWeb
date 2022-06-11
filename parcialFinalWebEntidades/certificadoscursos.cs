using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebEntidades
{
    public class certificadoscursos
    {
        [Key]
        public int idCertifiado { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre del certificado")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar la institución del certificado")]
        public string institucion { get; set; }
        public string descripcion { get; set; }
        public string enlace { get; set; }
        [Required]
        public int idUsuario { get; set; }

    }
}

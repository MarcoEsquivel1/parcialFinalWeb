using parcialFinalWebContexto;
using parcialFinalWebEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebDominio
{
    public class certificadoscursosMetodo
    {

        private readonly dbContext _contexto;
        public certificadoscursosMetodo(dbContext miContexto)
        {
            this._contexto = miContexto;
        }

        public IEnumerable<certificadoscursos> listadoPorIdUsuario(int idUs)
        {
            IEnumerable<certificadoscursos> listaCertificadosCursos = (from e in _contexto.certificadoscursos
                                                                       where e.idUsuario == idUs
                                                                       select new certificadoscursos
                                                                       {
                                                                           idCertifiado = e.idCertifiado,
                                                                           nombre = e.nombre,
                                                                           institucion = e.institucion,
                                                                           descripcion = e.descripcion,
                                                                           enlace = e.enlace,
                                                                           idUsuario = e.idUsuario
                                                                       });
            return listaCertificadosCursos.ToList();
        }

        public certificadoscursos buscarCertificadosCursos(int idExp)
        {
            certificadoscursos certificadocurso = _contexto.certificadoscursos.Find(idExp);
            return certificadocurso;
        }



    }
}

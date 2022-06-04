using parcialFinalWebContexto;
using parcialFinalWebEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebDominio
{
    public class gradosacademicosMetodo
    {
        
        private readonly dbContext _contexto;
        public gradosacademicosMetodo(dbContext miContexto)
        {
            this._contexto = miContexto;
        }

        public IEnumerable<gradosacademicos> listadoPorIdUsuario(int idUs)
        {
            IEnumerable<gradosacademicos> listaGrados = (from p in _contexto.gradosAcademicos
                                                         where p.idUsuario == idUs
                                                         select new gradosacademicos
                                                         {
                                                             idGrado = p.idGrado,
                                                             universidad = p.universidad,
                                                             profesion = p.profesion,
                                                             objetivo = p.objetivo,
                                                             idUsuario = p.idUsuario
                                                         });
            return listaGrados.ToList();
        }

        public gradosacademicos buscarGrado(int id)
        {
            gradosacademicos grado = _contexto.gradosAcademicos.Find(id);
            return grado;
        }
    }
}

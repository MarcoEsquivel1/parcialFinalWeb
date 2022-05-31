using parcialFinalWebContexto;
using parcialFinalWebEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebDominio
{
    public class experienciasMetodo
    {
        private readonly dbContext _contexto;
        public experienciasMetodo(dbContext miContexto)
        {
            this._contexto = miContexto;
        }
        
        public IEnumerable<experiencias> listadoPorIdUsuario(int idUs)
        {
            IEnumerable<experiencias> listaExperiencias = (from e in _contexto.experiencias
                                                           where e.idUsuario == idUs
                                                           select new experiencias
                                                           {
                                                               idExperiencia = e.idExperiencia,
                                                               experiencia = e.experiencia,
                                                               anios = e.anios,
                                                               idUsuario = e.idUsuario
                                                           });
            return listaExperiencias.ToList();
        }

        public experiencias buscarExperiencia(int idExp) {
            experiencias experiencia = _contexto.experiencias.Find(idExp);
            return experiencia;
        }

    }
}

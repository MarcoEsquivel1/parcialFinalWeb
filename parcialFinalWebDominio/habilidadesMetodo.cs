using parcialFinalWebContexto;
using parcialFinalWebEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebDominio
{
    public class habilidadesMetodo
    {
        
        private readonly dbContext _contexto;
        public habilidadesMetodo(dbContext miContexto)
        {
            this._contexto = miContexto;
        }

        public IEnumerable<habilidades> listado(int id)
        {
            IEnumerable<habilidades> listaHabilidades = (from h in _contexto.habilidades where h.idUsuario == id                                                        select new habilidades
                                                         {
                                                             idHabilidad = h.idHabilidad,
                                                             habilidad = h.habilidad,
                                                             calificacion = h.calificacion,
                                                             idUsuario = h.idUsuario
                                                         });

            return listaHabilidades.ToList();
        }

        public habilidades buscarHabilidad(int idHab)
        {
            habilidades habilidad = _contexto.habilidades.Find(idHab);
            return habilidad;
        }
    }
}

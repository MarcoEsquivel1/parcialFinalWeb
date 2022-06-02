using parcialFinalWebContexto;
using parcialFinalWebEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace parcialFinalWebDominio
{
    public class  portafoliosMetodo
    {
        private readonly dbContext _contexto;
        public portafoliosMetodo(dbContext miContexto)
        {
            this._contexto = miContexto;
        }

        public IEnumerable<portafolios> listadoPorIdUsuario(int idUs)
        {
            IEnumerable<portafolios> listaPortafolios = (from p in _contexto.portafolios
                                                           where p.idUsuario == idUs
                                                           select new portafolios
                                                           {
                                                               idPortafolio = p.idPortafolio,
                                                               nombreProyecto = p.nombreProyecto,
                                                               rol = p.rol,
                                                               resumen = p.resumen,
                                                               responsabilidades = p.responsabilidades,
                                                               tecnologiasUsadas = p.tecnologiasUsadas,
                                                               idUsuario = p.idUsuario
                                                           });
            return listaPortafolios.ToList();
        }

        public portafolios buscarPortafolio(int idPor)
        {
            portafolios portafolio = _contexto.portafolios.Find(idPor);
            return portafolio;
        }

    }
}

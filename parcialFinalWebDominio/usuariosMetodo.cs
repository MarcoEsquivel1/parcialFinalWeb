using parcialFinalWebContexto;
using parcialFinalWebEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebDominio
{
    public class usuariosMetodo
    {
        private readonly dbContext _contexto;
        public usuariosMetodo(dbContext miContexto)
        {
            this._contexto = miContexto;
        }


    }
}

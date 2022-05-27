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


    }
}

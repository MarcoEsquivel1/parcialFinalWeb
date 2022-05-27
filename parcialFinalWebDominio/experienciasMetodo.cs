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



    }
}

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

        public string nombreUsuario(int idUsuario)
        {
            var us = (from u in _contexto.usuarios
                      where u.idUsuario == idUsuario
                      select new usuarios
                      {
                          nombres = u.nombres,
                          apellidos = u.apellidos
                      }).FirstOrDefault();

            string nombre = us.nombres + " " + us.apellidos;

            return nombre;
        }

    }
}

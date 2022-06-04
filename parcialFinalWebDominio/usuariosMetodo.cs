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

        public IEnumerable<usuarios> listadoUsuarios()
        {
            IEnumerable<usuarios> listausuarios= (from e in _contexto.usuarios 


                                                  select new usuarios
                                                           {
                                                               idUsuario = e.idUsuario,
                                                               username = e.username,
                                                               foto = e.foto,
                                                               nombres = e.nombres,
                                                               apellidos = e.apellidos,
                                                               correo = e.correo
                                                               

                                                           });
            return listausuarios.ToList();
        }
       
        public usuarios GetUsuarios(int idUsuario)
        {
            usuarios usuario = _contexto.usuarios.Find(idUsuario);
            return usuario;
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

            string nombre;
            if (us == null || us.nombres == null || us.apellidos == null)
            {
                nombre = null;
            }
            else
            {
                nombre = us.nombres + " " + us.apellidos;
            }

            return nombre;
        }

    }
}

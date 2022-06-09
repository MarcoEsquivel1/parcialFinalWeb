using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using parcialFinalWebContexto;
using parcialFinalWebDominio;
using parcialFinalWebEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parcialFinalWeb.Controllers
{
    public class usuariosController : Controller
    {
        private readonly dbContext _contexto;
        public usuariosController(dbContext miContexto)
        {
            this._contexto = miContexto;
        }
        public IActionResult Index()
        {
            var usuarios = new usuariosMetodo(_contexto).listadoUsuarios();

            return View(usuarios);
        }
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(usuarios datos)
        {
            if (ModelState.IsValid)
            {
                if (datos.foto == null || datos.foto == "")
                {
                    datos.foto = "https://us.123rf.com/450wm/thesomeday123/thesomeday1231712/thesomeday123171200009/91087331-icono-de-perfil-de-avatar-predeterminado-para-hombre-marcador-de-posici%C3%B3n-de-foto-gris-vector-de-ilu.jpg";
                }
                var nuevoUsuario = new usuarios()
                {
                    username = datos.username,
                    foto = datos.foto,
                    nombres = datos.nombres,
                    apellidos = datos.apellidos,
                    correo = datos.correo,
                    linkedin = datos.linkedin,
                    introduccion = datos.introduccion,
                    facebook = datos.facebook,
                    otro = datos.otro,


                };

                _contexto.usuarios.Add(nuevoUsuario);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Crear", datos);
        }
      

        public ActionResult Editar(int id)

        {
            var usuario = new usuariosMetodo(_contexto).GetUsuarios(id);
            if (usuario == null)
            {
                return RedirectToAction("Error");
            }
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(usuarios datos)
        {
            if (datos.foto == null || datos.foto == "")
            {
                datos.foto = "https://us.123rf.com/450wm/thesomeday123/thesomeday1231712/thesomeday123171200009/91087331-icono-de-perfil-de-avatar-predeterminado-para-hombre-marcador-de-posici%C3%B3n-de-foto-gris-vector-de-ilu.jpg";
            }
            if (ModelState.IsValid)
            {
                _contexto.Entry(datos).State = EntityState.Modified;
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Editar", datos);

        }

        public ActionResult Eliminar(int id)
        {
            var usuario = new usuariosMetodo(_contexto).GetUsuarios(id);
            if (usuario == null)
            {
                return RedirectToAction("Error");
            }
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(usuarios datos)
        {
            
            
                _contexto.usuarios.Remove(datos);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            

         //   return RedirectToAction("Eliminar", datos);
        }



    }
}

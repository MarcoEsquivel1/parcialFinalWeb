using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using parcialFinalWebContexto;
using parcialFinalWebDominio;
using parcialFinalWebEntidades;

namespace parcialFinalWeb.Controllers
{
    public class gradosAcademicosController : Controller
    {

        private readonly dbContext _contexto;
        public gradosAcademicosController(dbContext miContexto)
        {
            this._contexto = miContexto;
        }
        public ActionResult Index(int id)
        {
            string nombreUsuario = new usuariosMetodo(_contexto).nombreUsuario(id);
            if (nombreUsuario == null)
            {
                return RedirectToAction("Error");
            }
            ViewBag.IdUsuario = id;
            ViewBag.NombreUsuario = nombreUsuario;
            var gradosAacdemicos = new gradosacademicosMetodo(_contexto).listadoPorIdUsuario(id);
            return View("Index", gradosAacdemicos);
        }

        public ActionResult crearGrado(int id)
        {
            string nombreUsuario = new usuariosMetodo(_contexto).nombreUsuario(id);
            if (nombreUsuario == null)
            {
                return RedirectToAction("Error");
            }
            ViewBag.IdUsuario = id;
            ViewBag.NombreUsuario = nombreUsuario;
            return View("crearGrado");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(gradosacademicos datos)
        {
            if (ModelState.IsValid)
            {
                var nuevoGrado = new gradosacademicos()
                {
                    idGrado = datos.idGrado,
                    universidad = datos.universidad,
                    profesion = datos.profesion,
                    objetivo = datos.objetivo,
                    idUsuario = datos.idUsuario
                };

                _contexto.gradosAcademicos.Add(nuevoGrado);
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datos.idUsuario });
            }
            return RedirectToAction("Crear", datos);
        }

        public ActionResult EditarGrado(int id)
        {
            var grado = new gradosacademicosMetodo(_contexto).buscarGrado(id);
            if (grado == null)
            {
                return RedirectToAction("Error");
            }
            return View("EditarGrado", grado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(gradosacademicos datos)
        {
            if (ModelState.IsValid)
            {
                _contexto.Entry(datos).State = EntityState.Modified;
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datos.idUsuario });
            }
            return RedirectToAction("Editar", datos);

        }

        public ActionResult EliminarGrado(int id)
        {
            var grado = new gradosacademicosMetodo(_contexto).buscarGrado(id);
            if (grado == null)
            {
                return RedirectToAction("Error");
            }
            return View("EliminarGrado", grado);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(gradosacademicos datos)
        {
            if (ModelState.IsValid)
            {
                _contexto.gradosAcademicos.Remove(datos);
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datos.idUsuario });
            }

            return RedirectToAction("Eliminar", datos);

        }
    }
}

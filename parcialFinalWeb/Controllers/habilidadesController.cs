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
    public class habilidadesController : Controller
    {
        private readonly dbContext _contexto;
        public habilidadesController(dbContext miContexto)
        {
            this._contexto = miContexto;
        }

        public ActionResult Index(int id)
        {
            string nombreUsiario = new usuariosMetodo(_contexto).nombreUsuario(id);
            ViewBag.IdUsuario = id;
            ViewBag.NombreUsuario = nombreUsiario;
            var habilidades = new habilidadesMetodo(_contexto).listado(id);
            return View(habilidades);
        }

        public ActionResult CrearHabilidad(int id)
        {
            string nombreUsuario = new usuariosMetodo(_contexto).nombreUsuario(id);
            ViewBag.IdUsuario = id;
            ViewBag.NombreUsuario = nombreUsuario;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(habilidades datosForm)
        {
            if (ModelState.IsValid)
            {
                var nuevaHabilidad = new habilidades()
                {
                    idHabilidad = datosForm.idHabilidad,
                    habilidad = datosForm.habilidad,
                    calificacion = datosForm.calificacion,
                    idUsuario = datosForm.idUsuario
                };

                _contexto.habilidades.Add(nuevaHabilidad);
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }
            return RedirectToAction("Crear", datosForm);
        }

        public ActionResult EditarHabilidad(int id)
        {
            var habilidad = new habilidadesMetodo(_contexto).buscarHabilidad(id);
            if (habilidad == null)
            {
                return RedirectToAction("Error");
            }
            return View(habilidad);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(habilidades datosForm)
        {
            if (ModelState.IsValid)
            {
                _contexto.Entry(datosForm).State = EntityState.Modified;
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }
            return RedirectToAction("Editar", datosForm);
        }

        public ActionResult EliminarHabilidad(int id)
        {
            var habilidad = new habilidadesMetodo(_contexto).buscarHabilidad(id);
            if (habilidad == null)
            {
                return RedirectToAction("Error");
            }
            return View(habilidad);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(habilidades datosForm)
        {
            if (ModelState.IsValid)
            {
                _contexto.habilidades.Remove(datosForm);
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }
            return RedirectToAction("Eliminar", datosForm);
        }
    }
}

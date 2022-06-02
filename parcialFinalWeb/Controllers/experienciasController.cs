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
    
    public class experienciasController : Controller
    {
        private readonly dbContext _contexto;
        public experienciasController(dbContext miContexto)
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
            var experiencias = new experienciasMetodo(_contexto).listadoPorIdUsuario(id);
            return View(experiencias);
        }

        public ActionResult CrearExperiencia(int id)
        {
            string nombreUsuario = new usuariosMetodo(_contexto).nombreUsuario(id);
            if (nombreUsuario == null)
            {
                return RedirectToAction("Error");
            }
            ViewBag.IdUsuario = id;
            ViewBag.NombreUsuario = nombreUsuario;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(experiencias datosForm) {
            if (ModelState.IsValid) {
                var nuevaExperiencia = new experiencias()
                {
                    idExperiencia = datosForm.idExperiencia,
                    experiencia = datosForm.experiencia,
                    anios = datosForm.anios,
                    idUsuario = datosForm.idUsuario
                };

                _contexto.experiencias.Add(nuevaExperiencia);
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }
            return RedirectToAction("Crear", datosForm);
        }

        public ActionResult EditarExperiencia(int id)
        {
            var experiencia = new experienciasMetodo(_contexto).buscarExperiencia(id);
            if (experiencia == null)
            {
                return RedirectToAction("Error");
            }
            return View(experiencia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(experiencias datosForm)
        {
            if (ModelState.IsValid)
            {
                _contexto.Entry(datosForm).State = EntityState.Modified;
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }
            return RedirectToAction("Editar", datosForm);

        }

        public ActionResult EliminarExperiencia(int id)
        {
            var experiencia = new experienciasMetodo(_contexto).buscarExperiencia(id);
            if (experiencia == null)
            {
                return RedirectToAction("Error");
            }
            return View(experiencia);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(experiencias datosForm) 
        {
            if (ModelState.IsValid)
            {
                _contexto.experiencias.Remove(datosForm);
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }
            
            return RedirectToAction("Eliminar", datosForm);
        }
    }
}

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
    public class portafoliosController : Controller
    {
        private readonly dbContext _contexto;
        public portafoliosController(dbContext miContexto)
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
            var experiencias = new portafoliosMetodo(_contexto).listadoPorIdUsuario(id);
            return View(experiencias);
        }

        public ActionResult CrearPortafolio(int id)
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
        public ActionResult Crear(portafolios datosForm)
        {
            if (ModelState.IsValid)
            {
                var nuevoPortafolio = new portafolios()
                {
                    idPortafolio = datosForm.idPortafolio,
                    nombreProyecto = datosForm.nombreProyecto,
                    rol = datosForm.rol,
                    resumen = datosForm.resumen,
                    responsabilidades = datosForm.responsabilidades,
                    tecnologiasUsadas = datosForm.tecnologiasUsadas,
                    idUsuario = datosForm.idUsuario
                };

                _contexto.portafolios.Add(nuevoPortafolio);
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }
            return RedirectToAction("Crear", datosForm);
        }

        public ActionResult EditarPortafolio(int id)
        {
            var portafolio = new portafoliosMetodo(_contexto).buscarPortafolio(id);
            if (portafolio == null)
            {
                return RedirectToAction("Error");
            }
            return View(portafolio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(portafolios datosForm)
        {
            if (ModelState.IsValid)
            {
                _contexto.Entry(datosForm).State = EntityState.Modified;
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }
            return RedirectToAction("Editar", datosForm);

        }

        public ActionResult EliminarPortafolio(int id)
        {
            var portafolio = new portafoliosMetodo(_contexto).buscarPortafolio(id);
            if (portafolio == null)
            {
                return RedirectToAction("Error");
            }
            return View(portafolio);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(portafolios datosForm)
        {
            if (ModelState.IsValid)
            {
                _contexto.portafolios.Remove(datosForm);
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }

            return RedirectToAction("Eliminar", datosForm);
        }
    }
}

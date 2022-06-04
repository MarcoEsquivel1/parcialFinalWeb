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
    public class certificadoscursosController : Controller
    {

        private readonly dbContext _contexto;
        public certificadoscursosController(dbContext miContexto)
        {
            this._contexto = miContexto;
        }
        public IActionResult Index(int id)
        {
            string nombreUsuario = new usuariosMetodo(_contexto).nombreUsuario(id);
            if (nombreUsuario == null)
            {
                return RedirectToAction("Error");
            }
            ViewBag.IdUsuario = id;
            ViewBag.NombreUsuario = nombreUsuario;
            var certificadoscursos = new certificadoscursosMetodo(_contexto).listadoPorIdUsuario(id);
            return View(certificadoscursos);
        }

        public ActionResult CrearCertificadosCursos(int id)
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
        public ActionResult Crear(certificadoscursos datosForm)
        {
            if (ModelState.IsValid)
            {
                var nuevaCertificadosCursos = new certificadoscursos()
                {
                    idCertifiado = datosForm.idCertifiado,
                    nombre = datosForm.nombre,
                    institucion = datosForm.institucion,
                    descripcion = datosForm.descripcion,
                    enlace = datosForm.enlace,
                    idUsuario = datosForm.idUsuario
                };

                _contexto.certificadoscursos.Add(nuevaCertificadosCursos);
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }
            return RedirectToAction("Crear", datosForm);
        }

        public ActionResult EditarCertificadosCursos(int id)
        {
            var certificadoscursos = new certificadoscursosMetodo(_contexto).buscarCertificadosCursos(id);
            if (certificadoscursos == null)
            {
                return RedirectToAction("Error");
            }
            return View(certificadoscursos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(certificadoscursos datosForm)
        {
            if (ModelState.IsValid)
            {
                _contexto.Entry(datosForm).State = EntityState.Modified;
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }
            return RedirectToAction("Editar", datosForm);

        }

        public ActionResult EliminarCertificadosCursos(int id)
        {
            var certificadoscursos = new certificadoscursosMetodo(_contexto).buscarCertificadosCursos(id);
            if (certificadoscursos == null)
            {
                return RedirectToAction("Error");
            }
            return View(certificadoscursos);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(certificadoscursos datosForm)
        {
            if (ModelState.IsValid)
            {
                _contexto.certificadoscursos.Remove(datosForm);
                _contexto.SaveChanges();
                return RedirectToAction("Index", new { id = datosForm.idUsuario });
            }

            return RedirectToAction("Eliminar", datosForm);
        }
    }
}

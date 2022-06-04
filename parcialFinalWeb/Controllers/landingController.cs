using Microsoft.AspNetCore.Mvc;
using parcialFinalWebContexto;
using parcialFinalWebDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parcialFinalWeb.Controllers
{
    public class landingController : Controller
    {
        private readonly dbContext _contexto;
        public landingController(dbContext miContexto)
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
            return View();
        }
    }
}

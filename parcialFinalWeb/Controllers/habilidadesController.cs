using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            var habilidades = new habilidadesMetodo(_contexto).listado();
            return View(habilidades);
        }
    }
}

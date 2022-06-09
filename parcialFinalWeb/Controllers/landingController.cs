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
    public class landingController : Controller
    {
        private readonly dbContext _contexto;
        public landingController(dbContext miContexto)
        {
            this._contexto = miContexto;
        }
        public ActionResult Index(int id)
        {
            IEnumerable<experiencias> experiencias = new experienciasMetodo(_contexto).listadoPorIdUsuario(id);
            IEnumerable<habilidades> habilidades = new habilidadesMetodo(_contexto).listado(id);
            IEnumerable<portafolios> portafolios = new portafoliosMetodo(_contexto).listadoPorIdUsuario(id);
            IEnumerable<certificadoscursos> certificados = new certificadoscursosMetodo(_contexto).listadoPorIdUsuario(id);
            IEnumerable<gradosacademicos> grados = new gradosacademicosMetodo(_contexto).listadoPorIdUsuario(id);
            usuarios usuario = new usuariosMetodo(_contexto).GetUsuarios(id);
            if (usuario == null || experiencias == null || habilidades == null || 
                portafolios == null || certificados == null || grados == null)
            {
                return RedirectToAction("Error");
            }
            ViewBag.Experiencias = experiencias;
            ViewBag.Habilidades = habilidades;
            ViewBag.Portafolios = portafolios;
            ViewBag.Certificados = certificados;
            ViewBag.Grados = grados;
            
            return View(usuario);
        }
    }
}

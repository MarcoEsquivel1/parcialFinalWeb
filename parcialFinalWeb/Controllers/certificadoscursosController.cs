using Microsoft.AspNetCore.Mvc;
using parcialFinalWebContexto;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}

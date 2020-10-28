using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldConf.Controllers
{
    [Authorize]
    public class PonenteController : Controller
    {
        [HttpGet]
        public IActionResult Ponente()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Editar()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Eliminar()
        {
            return View();
        }
    }
}

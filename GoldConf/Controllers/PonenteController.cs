using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GoldConf.Controllers
{
    public class PonenteController : Controller
    {
        public IActionResult Registrar()
        {
            return View();
        }
    }
}

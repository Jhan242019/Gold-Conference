using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoldConf.Models;
using System.Data.Entity;

namespace GoldConf.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GoldConfContext _context;

        public HomeController(ILogger<HomeController> logger, GoldConfContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var Ponente = _context.Ponentes
                .ToList();

            ViewBag.Conferencia = _context.Conferencias.
                Include(o => o.Ponentes).
                Where(o => o.FechaConf >= DateTime.Now).
                ToList();
            var compra = _context.Compras.
                ToList();

            Console.WriteLine(compra.Count());
            return View(Ponente);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

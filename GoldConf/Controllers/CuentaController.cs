using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using GoldConf.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace GoldConf.Controllers
{
    [Authorize]
    public class CuentaController : BaseController
    {
        private readonly GoldConfContext _context;
        public IHostEnvironment _hostEnv;

        public CuentaController(GoldConfContext context, IHostEnvironment hostEnv) : base(context)
        {
            _context = context;
            _hostEnv = hostEnv;
        }
        [HttpGet]
        public IActionResult Index()
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                ViewBag.Usuario = "LanRhXXX";
            }
            var cuentas = _context.Cuentas
                .Where(o => o.UserId == LoggedUser().Id)
                .ToList();

            ViewBag.Types = new List<string> { "Efectivo", "Debito" };
            ViewBag.Currency = new List<string> { "Soles" };

            ViewBag.Total = cuentas.Sum(o => o.Amount);
            return View(cuentas);
        }
        [HttpGet]
        public ActionResult Crear()
        {
            var cuentas = _context.Cuentas.
                Where(o => o.UserId == LoggedUser().Id).
                ToList();
            if (cuentas.Count() == 0)
            {
                ViewBag.Types = new List<string> { "Efectivo", "Debito" };
                ViewBag.Currency = new List<string> { "Soles" };
                return View("Crear", new Cuenta());
            }
            else
            {
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        public ActionResult Crear(Cuenta cuenta)
        {
            var cuentas = _context.Cuentas.
                Where(o => o.UserId == LoggedUser().Id).
                ToList();
            if (cuentas.Count() == 0)
            {
                if (cuenta.Amount < 0)
                {
                    ModelState.AddModelError("Amount", "Valor negativo");
                }
                cuenta.UserId = LoggedUser().Id;
                if (ModelState.IsValid)
                {
                    if (cuenta.Amount != 0)
                    {
                        cuenta.Transaccions = new List<Transaccion>
                {
                    new Transaccion
                    {
                        FechaHora = DateTime.Now,
                        Tipo = "Ingreso",
                        Amount = cuenta.Amount,
                        Motivo = "Monto Inicial"
                    }
                };
                    }
                    _context.Cuentas.Add(cuenta);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Types = new List<string> { "Efectivo", "Debito" };
                    ViewBag.Currency = new List<string> { "Soles" };
                    return View("Crear", cuenta);
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        public ActionResult Transaccion(int id)
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                ViewBag.Usuario = "LanRhXXX";
            }
            var transacciones = _context.Transacciones.Where(o => o.CuentaId == id).ToList();
            ViewBag.Cuenta = _context.Cuentas.First(o => o.Id == id);
            return View(transacciones);
        }
    }
}

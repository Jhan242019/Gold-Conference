using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GoldConf.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace GoldConf.Controllers
{
    [Authorize]
    public class PonenteController : BaseController
    {
        private readonly GoldConfContext _context;
        public IHostEnvironment _hostEnv;

        public PonenteController(GoldConfContext context, IHostEnvironment hostEnv) : base(context)
        {
            _context = context;
            _hostEnv = hostEnv;
        }

        [HttpGet]
        public ActionResult Ponente(string search)
        {
            if (LoggedUser().Username != "LanRhXXX")
                ViewBag.Usuario = "LanRhXXX";

            ViewBag.Buscar = search;

            var Ponente = _context.Ponentes
                .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                Ponente = Ponente.Where(s => s.NomApe.Contains(search)).ToList();
                return View(Ponente);
            }

            return View(Ponente);
        }
        [HttpGet]
        public ActionResult Detalle(int idPonente)
        {
            ViewBag.Cuenta = _context.Cuentas
                   .Where(o => o.UserId == LoggedUser().Id)
                   .ToList();
            if (LoggedUser().Username != "LanRhXXX")
            {
                ViewBag.Usuario = "LanRhXXX";
                ViewBag.Compra = _context.Compras.
                    Where(o => o.IdUser == LoggedUser().Id).
                    ToList();
            }
            else
            {
                ViewBag.Compra = _context.Compras.
                    ToList();
            }

            var Ponente = _context.Ponentes.
                Where(o => o.Id == idPonente).
                FirstOrDefault();

            ViewBag.Conferencias = _context.Conferencias
                .Where(o => o.PonenteId == idPonente)
                .ToList();

            ViewBag.Cursos = _context.Conferencias
                .Where(o => o.PonenteId == idPonente)
                .OrderByDescending(o => o.FechaConf)
                .Count();

            return View(Ponente);
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                var ponentes = _context.Ponentes
                     .ToList();
                return RedirectToAction("Ponente", ponentes);
            }
            else
            {
                return View(new Ponente());
            }
        }
        [HttpPost]
        public ActionResult Registrar(Ponente ponente, IFormFile image, string email, string telefono)
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                var ponentes = _context.Ponentes
                    .ToList();
                return RedirectToAction("Ponente", ponentes);
            }
            else
            {
                var ponentes = _context.Ponentes.ToList();
                foreach (var item in ponentes)
                {
                    if (item.Email == email)
                        ModelState.AddModelError("Email", "Este email ya existe");
                    if (item.Telefono == telefono)
                        ModelState.AddModelError("Telefono", "Este numero ya existe");
                }
                if (ModelState.IsValid)
                {
                    if (image != null && image.Length > 0)
                    {
                        var basePath = _hostEnv.ContentRootPath + @"\wwwroot";
                        var ruta = @"\Ponentes\" + image.FileName;

                        using var strem = new FileStream(basePath + ruta, FileMode.Create);
                        image.CopyTo(strem);
                        ponente.Imagen = ruta;
                    }
                    _context.Ponentes.Add(ponente);
                    _context.SaveChanges();
                    return RedirectToAction("Ponente");
                }
                else
                {
                    return RedirectToAction("Registrar", ponente);
                }
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                var ponente = _context.Ponentes
                    .ToList();
                return RedirectToAction("Ponente", ponente);
            }
            else
            {
                var ponente = _context.Ponentes.Where(o => o.Id == id).FirstOrDefault();
                return View(ponente);
            }
        }
        [HttpPost]
        public ActionResult Edit(Ponente ponente)
        {
            if (ModelState.IsValid)
            {
                _context.Ponentes.Update(ponente);
                _context.SaveChanges();
                return RedirectToAction("Ponente");
            }
            else
            {
                return View(ponente);
            }
        }

    }
}

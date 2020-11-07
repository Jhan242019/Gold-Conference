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
                return View("Ponente", Ponente);
            }

            return View("Ponente", Ponente);
        }
        [HttpGet]
        public ActionResult Detalle(int idPonente)
        {
            if (LoggedUser().Username != "LanRhXXX")
                ViewBag.Usuario = "LanRhXXX";

            var Ponente = _context.Ponentes.
                Where(o => o.Id == idPonente).
                ToList();

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
                return View("Registrar", new Ponente());
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

        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    if (LoggedUser().Username != "LanRhXXX")
        //    {
        //        var conferencias = _context.Conferencias
        //            .Include(o => o.Ponentes)
        //            .ToList();
        //        return RedirectToAction("Conferencias", conferencias);
        //    }
        //    else
        //    {
        //        ViewBag.Ponentes = _context.Ponentes.ToList();
        //        var account = _context.Conferencias.Where(o => o.Id == id).FirstOrDefault(); // si no lo encutra retorna un null
        //        return View(account);
        //    }
        //}
        //[HttpPost]
        //public ActionResult Edit(Conferencia conferencia, IFormFile image)
        //{
        //    if (LoggedUser().Username != "LanRhXXX")
        //    {
        //        var conferencias = _context.Conferencias
        //            .Include(o => o.Ponentes)
        //            .ToList();
        //        return RedirectToAction("Conferencias", conferencias);
        //    }
        //    else
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Conferencias.Update(conferencia);
        //            _context.SaveChanges();
        //            return RedirectToAction("Conferencias");
        //        }
        //        else
        //        {
        //            ViewBag.Ponentes = _context.Ponentes.ToList();
        //            return View(conferencia);
        //        }
        //    }
        //}

        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    if (LoggedUser().Username != "LanRhXXX")
        //    {
        //        var conferencias = _context.Conferencias
        //            .Include(o => o.Ponentes)
        //            .ToList();
        //        return RedirectToAction("Conferencias", conferencias);
        //    }
        //    else
        //    {
        //        var conferencia = _context.Conferencias.Where(o => o.Id == id).FirstOrDefault();
        //        _context.Conferencias.Remove(conferencia);
        //        _context.SaveChanges();
        //        return RedirectToAction("Conferencias");
        //    }
        //}

        //[Authorize]
        //[HttpGet]
        //public ActionResult Comprar(Comprar comprar, int idF)
        //{
        //    var compra = _context.Compras.ToList();

        //    //foreach (var item in compra)
        //    //{
        //    //    if (item.IdConferencia != idF)
        //    //    {

        //    comprar.IdUser = LoggedUser().Id;
        //    comprar.IdConferencia = idF;

        //    //Console.WriteLine("Conferencia : " + item.IdConferencia);

        //    _context.Compras.Add(comprar);
        //    _context.SaveChanges();

        //    //        return RedirectToAction("Conferencias");
        //    //    }
        //    //}

        //    return RedirectToAction("Conferencias");
        //}

        //[Authorize]
        //public ActionResult CompraConf(Comprar comprar, string search)
        //{
        //    var compras = _context.Ponentes.ToList();

        //    ViewBag.Compras = _context.Compras.ToList().Where(o => o.IdUser == LoggedUser().Id);

        //    ViewBag.Buscar = search;
        //    var compra = _context.Conferencias
        //            .Include(o => o.Ponentes)
        //            .ToList();

        //    if (!string.IsNullOrEmpty(search))
        //    {
        //        compra = compra.Where(s => s.Ponentes.NomApe.Contains(search) || s.TituloConf.Contains(search)).ToList();
        //        return View("CompraConf", compra);
        //    }
        //    return View("CompraConf", compra);
        //}
    }
}

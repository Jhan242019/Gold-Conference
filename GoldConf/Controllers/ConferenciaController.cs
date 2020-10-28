using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using GoldConf.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace GoldConf.Controllers
{
    [Authorize]
    public class ConferenciaController : BaseController
    {

        private GoldConfContext _context;
        public IHostEnvironment _hostEnv;

        public ConferenciaController(GoldConfContext context, IHostEnvironment hostEnv) : base(context)
        {
            _context = context;
            _hostEnv = hostEnv;
        }
        [HttpGet]
        public ActionResult Conferencias(string search)
        {
            if (LoggedUser().Username != "LanRhXXX")
                ViewBag.Usuario = "LanRhXXX";
            
            ViewBag.Buscar = search;

            ViewBag.Ponentes = _context.Ponentes.ToList();
            var conferencias = _context.Conferencias
                .Include(o => o.Ponentes)
                .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                conferencias = conferencias.Where(s => s.Ponentes.NomApe.Contains(search) || s.TituloConf.Contains(search)).ToList();
                return View("Conferencias", conferencias);
            }

            return View("Conferencias",conferencias);
        }

        [HttpGet]
        public ActionResult Create()
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                var conferencias = _context.Conferencias
                     .Include(o => o.Ponentes)
                     .ToList();
                return RedirectToAction("Conferencias", conferencias);
            }
            else
            {
                ViewBag.Ponentes = _context.Ponentes.ToList();
                return View("Create", new Conferencia());
            }
        }
        [HttpPost]
        public ActionResult Create(Conferencia conferencia, IFormFile image)
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                var conferencias = _context.Conferencias
                    .Include(o => o.Ponentes)
                    .ToList();
                return RedirectToAction("Conferencias", conferencias);
            }
            else
            {
                if (ModelState.IsValid)
                {
                    // guardar archivo en el servidor
                    if (image != null && image.Length > 0)
                    {
                        var basePath = _hostEnv.ContentRootPath + @"\wwwroot";
                        var ruta = @"\files\" + image.FileName;

                        using (var strem = new FileStream(basePath + ruta, FileMode.Create))
                        {
                            image.CopyTo(strem);
                            conferencia.ImagePath = ruta;
                        }
                    }
                    _context.Conferencias.Add(conferencia);
                    _context.SaveChanges();
                    return RedirectToAction("Conferencias");
                }
                else
                {
                    ViewBag.Ponentes = _context.Ponentes.ToList();
                    return View("Create", conferencia);
                }
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                var conferencias = _context.Conferencias
                    .Include(o => o.Ponentes)
                    .ToList();
                return RedirectToAction("Conferencias", conferencias);
            }
            else
            {
                ViewBag.Ponentes = _context.Ponentes.ToList();
                var account = _context.Conferencias.Where(o => o.Id == id).FirstOrDefault(); // si no lo encutra retorna un null
                return View(account);
            }
        }
        [HttpPost]
        public ActionResult Edit(Conferencia conferencia, IFormFile image)
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                var conferencias = _context.Conferencias
                    .Include(o => o.Ponentes)
                    .ToList();
                return RedirectToAction("Conferencias", conferencias);
            }
            else
            {
                if (ModelState.IsValid)
                {
                    _context.Conferencias.Update(conferencia);
                    _context.SaveChanges();
                    return RedirectToAction("Conferencias");
                }
                else
                {
                    ViewBag.Ponentes = _context.Ponentes.ToList();
                    return View(conferencia);
                }
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                var conferencias = _context.Conferencias
                    .Include(o => o.Ponentes)
                    .ToList();
                return RedirectToAction("Conferencias", conferencias);
            }
            else
            {
                var conferencia = _context.Conferencias.Where(o => o.Id == id).FirstOrDefault();
                _context.Conferencias.Remove(conferencia);
                _context.SaveChanges();
                return RedirectToAction("Conferencias");
            }
        }

        [Authorize]
        [HttpGet]
        public ActionResult Comprar(Comprar comprar, int idF)
        {
            var compra = _context.Compras.ToList();

            //foreach (var item in compra)
            //{
            //    if (item.IdConferencia != idF)
            //    {

                    comprar.IdUser = LoggedUser().Id;
                    comprar.IdConferencia = idF;

                    //Console.WriteLine("Conferencia : " + item.IdConferencia);

                    _context.Compras.Add(comprar);
                    _context.SaveChanges();

            //        return RedirectToAction("Conferencias");
            //    }
            //}

            return RedirectToAction("Conferencias");
        }

        [Authorize]
        public ActionResult CompraConf(Comprar comprar, string search)
        {
            var compras = _context.Ponentes.ToList();

            ViewBag.Compras = _context.Compras.ToList().Where(o => o.IdUser == LoggedUser().Id);

            ViewBag.Buscar = search;
            var compra = _context.Conferencias
                    .Include(o => o.Ponentes)
                    .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                compra = compra.Where(s => s.Ponentes.NomApe.Contains(search) || s.TituloConf.Contains(search)).ToList();
                return View("CompraConf", compra);
            }
            return View("CompraConf", compra);
        }
    }
}

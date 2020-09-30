using System;
using System.Collections.Generic;
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
        public ActionResult Index()
        {
            var conferencia = new Conferencia();
            var conferencias = _context.Conferencias
                .Where(o => o.UserId == LoggedUser().Id);

            return View(conferencias);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create", new Conferencia());
        }

        [HttpPost]
        public ActionResult Create(Conferencia conferencia, IFormFile image) 
        {
            conferencia.UserId = LoggedUser().Id;

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
                return RedirectToAction("Index");
            }
            return View("Create", conferencia);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var account = _context.Conferencias.Where(o => o.Id == id).FirstOrDefault(); // si no lo encutra retorna un null

            return View(account);
        }

        [HttpPost]
        public ActionResult Edit(Conferencia conferencia)
        {
            if (ModelState.IsValid)
            {
                _context.Conferencias.Update(conferencia);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conferencia);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var account = _context.Conferencias.Where(o => o.Id == id).FirstOrDefault();
            _context.Conferencias.Remove(account);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [Authorize]
        public ActionResult Conferencias()
        {
            return View("Conferencias");
        }
    }
}

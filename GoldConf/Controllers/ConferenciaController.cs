﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using GoldConf.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using PayPal.Api;

namespace GoldConf.Controllers
{
    [Authorize]
    public class ConferenciaController : BaseController
    {

        private readonly GoldConfContext _context;
        public IHostEnvironment _hostEnv;

        public ConferenciaController(GoldConfContext context, IHostEnvironment hostEnv) : base(context)
        {
            _context = context;
            _hostEnv = hostEnv;
        }
        [HttpGet]
        public ActionResult Conferencias(string search)
        {
            var ponentes = _context.Ponentes.ToList();
            var conferencias = _context.Conferencias.ToList();
            ViewBag.Cuenta = _context.Cuentas
                .Where(o => o.UserId == LoggedUser().Id)
                .ToList();
            if (LoggedUser().Username != "LanRhXXX")
            {
                ViewBag.Usuario = "LanRhXXX";
                conferencias = _context.Conferencias
                    .Include(o => o.Ponentes)
                    .OrderByDescending(o => o.FechaConf)
                    .Where(o => o.FechaConf >= DateTime.Now)
                    .ToList();
                ViewBag.Compra = _context.Compras.
                    Where(o => o.IdUser == LoggedUser().Id).
                    ToList();
            }
            else
            {
                conferencias = _context.Conferencias
                    .Include(o => o.Ponentes)
                    .OrderByDescending(o => o.FechaConf)
                    .ToList();
                ViewBag.Compra = _context.Compras.
                    ToList();
            }

            ViewBag.Buscar = search;

            ViewBag.IdUser = LoggedUser().Id;

            if (!string.IsNullOrEmpty(search))
            {
                conferencias = conferencias.Where(s => s.Ponentes.NomApe.Contains(search) || s.TituloConf.Contains(search)).ToList();
                return View(conferencias);
            }

            return View(conferencias);
        }

        public ActionResult Detalle(int idConferencia)
        {
            if (LoggedUser().Username != "LanRhXXX")
                ViewBag.Usuario = "LanRhXXX";

            var compra = _context.Compras.ToList().Where(o => o.IdConferencia == idConferencia);
            ViewBag.Compra = compra.Count();

            ViewBag.Ponentes = _context.Ponentes.ToList();

            var conferencias = _context.Conferencias
                .Where(o => o.Id == idConferencia)
                .Include(o => o.Ponentes)
                .FirstOrDefault();

            ViewBag.IdUser = LoggedUser().Id;

            return View(conferencias);
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
                return View(new Conferencia());
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

                        using var strem = new FileStream(basePath + ruta, FileMode.Create);
                        image.CopyTo(strem);
                        conferencia.ImagePath = ruta;
                    }
                    _context.Conferencias.Add(conferencia);
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
        public ActionResult Edit(int id)
        {
            if (LoggedUser().Username != "LanRhXXX")
            {
                var conferencias = _context.Conferencias
                    .Include(o => o.Ponentes)
                    .Where(o => o.Id == id)
                    .FirstOrDefault();
                return RedirectToAction("Conferencias", conferencias);
            }
            else
            {
                ViewBag.Ponentes = _context.Ponentes.ToList();
                var account = _context.Conferencias.Where(o => o.Id == id).FirstOrDefault();
                return View(account);
            }
        }
        [HttpPost]
        public ActionResult Edit(Conferencia conferencia, IFormFile image)
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

        [HttpGet]
        public ActionResult Comprar(Comprar comprar, int idF, string titulo, decimal monto)
        {
            var cuenta = _context.Cuentas.
                Where(o => o.UserId == LoggedUser().Id).
                ToList();
            if (cuenta.Count() > 0)
            {
                var compra = _context.Compras.
                ToList();

                foreach (var item in compra)
                {
                    if (item.IdUser == LoggedUser().Id && item.IdConferencia == idF)
                    {
                        TempData["COMPRA"] = "Esta conferencia ya ha sido comprada";
                        ModelState.AddModelError("Error", "Conferencia ya comprada");
                    }
                }
                if (ModelState.IsValid)
                {
                    foreach (var item in cuenta)
                    {
                        int idCuenta = item.Id;
                        var transaccionCli = new Transaccion
                        {
                            CuentaId = idCuenta,
                            FechaHora = DateTime.Now,
                            Tipo = "Compra",
                            Amount = monto * -1,
                            Motivo = "Conferencia " + titulo + " Comprada"
                        };
                        var transaccionAd = new Transaccion
                        {
                            CuentaId = 5,
                            FechaHora = DateTime.Now,
                            Tipo = "Venta",
                            Amount = monto,
                            Motivo = "Conferencia " + titulo + " Comprada"
                        };
                        _context.Transacciones.Add(transaccionCli);
                        _context.Transacciones.Add(transaccionAd);
                        ModificaMontoCuenta(transaccionCli.CuentaId);
                        ModificaMontoCuenta(transaccionAd.CuentaId);
                    }
                    comprar.IdUser = LoggedUser().Id;
                    comprar.IdConferencia = idF;
                    _context.Compras.Add(comprar);
                    _context.SaveChanges();

                    return RedirectToAction("Conferencias");
                }
            }
            return RedirectToAction("Conferencias");
        }

        [HttpGet]
        public ActionResult Pasadas(string search)
        {
            if (LoggedUser().Username != "LanRhXXX")
                ViewBag.Usuario = "LanRhXXX";

            var ponente = _context.Ponentes.ToList();

            var conferencia = _context.Conferencias
                .Include(o => o.Ponentes)
                .ToList();

            var compra = _context.Compras
                    .Include(o => o.Conferencia)
                    .Where(o => o.IdUser == LoggedUser().Id)
                    .Where(o => o.Conferencia.FechaConf < DateTime.Now)
                    .OrderByDescending(o => o.Conferencia.FechaConf)
                    .ToList();

            DateTime fecha = DateTime.Today;
            ViewBag.fecha = fecha;

            ViewBag.Buscar = search;

            if (!string.IsNullOrEmpty(search))
            {
                compra = compra.Where(s => s.Conferencia.Ponentes.NomApe.Contains(search) || s.Conferencia.TituloConf.Contains(search)).ToList();
                return View(compra);
            }
            return View(compra);
        }
        [HttpGet]
        public ActionResult Futuras(string search)
        {
            if (LoggedUser().Username != "LanRhXXX")
                ViewBag.Usuario = "LanRhXXX";

            var ponente = _context.Ponentes.ToList();

            var conferencia = _context.Conferencias
                .Include(o => o.Ponentes)
                .ToList();

            var compra = _context.Compras
                    .Include(o => o.Conferencia)
                    .Where(o => o.IdUser == LoggedUser().Id)
                    .Where(o => o.Conferencia.FechaConf >= DateTime.Now)
                    .OrderBy(o => o.Conferencia.FechaConf)
                    .ToList();

            DateTime fecha = DateTime.Today;
            ViewBag.fecha = fecha;

            ViewBag.Buscar = search;

            if (!string.IsNullOrEmpty(search))
            {
                compra = compra.Where(s => s.Conferencia.Ponentes.NomApe.Contains(search) || s.Conferencia.TituloConf.Contains(search)).ToList();
                return View(compra);
            }
            return View(compra);
        }
        private void ModificaMontoCuenta(int cuentaId)
        {
            var transaccions = _context.Transacciones.ToList();
            var cuenta = _context.Cuentas
                .Include(o => o.Transaccions)
                .FirstOrDefault(o => o.Id == cuentaId);

            var total = cuenta.Transaccions.Sum(o => o.Amount);
            cuenta.Amount = total;
            _context.SaveChanges();

        }
        ////work with Paypal Payment
        //private Payment payment;

        //// Create a payment using a APIContext
        //private Payment CreatePAyment(APIContext apiContext,string redirectUrl)
        //{
        //    var listItems = new ItemList(){items = new List<Item>()};

        //}

    }
}

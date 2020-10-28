using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GoldConf.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;

namespace GoldConf.Controllers
{

    public class AuthController : BaseController
    {
        private readonly GoldConfContext context;
        private readonly IConfiguration configuration;
        public IHostEnvironment hostEnv;

        public AuthController(GoldConfContext context, IHostEnvironment hostEnv, IConfiguration configuration) : base(context)
        {
            this.context = context;
            this.configuration = configuration;
            this.hostEnv = hostEnv;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            /* validar si el usuario existe en la base de datos y 
             * verificar que el password sea correcto*/
            var user = context.Users
                .Where(o => o.Username == username && o.Password == CreateHash(password))
                .FirstOrDefault();

            if (user != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, username)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("Login", "Usuario o contraseña incorrectos.");
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        private string CreateHash(string input)
        {
            var sha = SHA256.Create();
            input += configuration.GetValue<string>("Token");
            var hash = sha.ComputeHash(Encoding.Default.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        } /* ...::: CAMBIE DESDE ACA PARA ABAJO :::... */
        [HttpPost]
        public ActionResult Registrar(User user, string password, string passwordConf, string email, string username)
        {
            var usuarios = context.Users.ToList();
            foreach (var item in usuarios)
            {
                if (item.Email == email)
                    ModelState.AddModelError("Email", "Este email ya existe");
                if (item.Username == username)
                    ModelState.AddModelError("Username", "Este usuario ya existe");
            }

            if (user.Password != passwordConf) // <-- para convalidar contraseña y confirmacion de contraseña
                ModelState.AddModelError("PasswordConf", "Las contraseñas no coinciden");

            if (ModelState.IsValid)
            {
                user.Email = email;
                user.Password = CreateHash(password);
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View("Registrar", user);
        }
    }
}

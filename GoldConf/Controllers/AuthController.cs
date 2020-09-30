using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GoldConf.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;

namespace GoldConf.Controllers
{

    public class AuthController : BaseController
    {
        private readonly GoldConfContext context;
        private readonly IConfiguration configuration;

        public AuthController(GoldConfContext context, IConfiguration configuration) : base(context)
        {
            this.context = context;
            this.configuration = configuration;
        }

        [Authorize]
        public string LoggedUserView()
        {
            return "El usuario Logeuado es:" + LoggedUser().Id;
        }

        [HttpGet]
        public string Index(string input)
        {
            return CreateHash(input);
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
                if (user.Username == "admin" && user.Password == "ky0MGWs71WJ/g1qG1VjHXZBKmXsOeQslnbHr2WoMLG0=")
                {
                    // Autenticaremos
                    var claims1 = new List<Claim> {
                    new Claim(ClaimTypes.Name, username)
                };

                    var claimsIdentity1 = new ClaimsIdentity(claims1, "Login");
                    var claimsPrincipal1 = new ClaimsPrincipal(claimsIdentity1);

                    HttpContext.SignInAsync(claimsPrincipal1);

                    return RedirectToAction("Conferencias", "Conferencia");
                }
                else
                {
                    // Autenticaremos
                    var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, username)
                };

                    var claimsIdentity = new ClaimsIdentity(claims, "Login");
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    HttpContext.SignInAsync(claimsPrincipal);


                    return RedirectToAction("Index", "Home");
                }
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

        public ActionResult Registrar()
        {
            return View("Registrar");
        }
    }

}

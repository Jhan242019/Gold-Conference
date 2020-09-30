using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoldConf.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldConf.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly GoldConfContext context;
        public BaseController(GoldConfContext context)
        {
            this.context = context;
        }

        protected User LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = context.Users.Where(o => o.Username == claim.Value).FirstOrDefault();
            return user;
        }
    }
}

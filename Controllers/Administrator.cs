using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SocialLogin.Controllers
{
    public class Administrator : Controller
    {
        [Authorize(Roles = "Administrator")]
        
        public IActionResult Index()
        {
            return View();
        }
    }
}

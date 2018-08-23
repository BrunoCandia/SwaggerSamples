using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroGen.Controllers
{
    public class HeroesMvcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
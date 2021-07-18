using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnaBella.Controllers
{
    public class BiografiasController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Biografia";

            return View();
        }
    }
}

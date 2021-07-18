using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnaBella.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Contato";

            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Socios.Controllers
{
    [Route("/Nombre")]
    public class UsuariosController : Controller
    { 
        //[HttpGet]
        [Route("/Nombre/Luis")]
        public IActionResult Index(String data, int age)
        {
            ViewData["id"] = data +" " + age;
            return View();
        }
    }
}
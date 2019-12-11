using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Socios.Areas.Socio.Controllers
{
    [Area("Socio")]
    public class SocioController : Controller
    {
        public IActionResult Socio()
        {
            return View(); 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Socios.Data;
using Socios.Models;

namespace Socios.Controllers
{
    public class MantenimientoSocioController : Controller
    {
        public SocioModel Test = new SocioModel
        {
            Id = 5,
            Nombre = "asdadaddsa",
            Apellido = "dasdadadasd",
            Cedula = "adadasasdasd",
            Direccion = "aasdadadasdasd",
            Edad = 54,
            Fecha_de_nacimiento = DateTime.Now,
            Datos_de_membresia="Primium",
            Estado_Membresia="activo",
            Fecha_de_ingreso = DateTime.Now,
            Fecha_de_salida = DateTime.Now,

        };
        private ApplicationDbContext dbContext;
       
        public MantenimientoSocioController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        // GET: MantenimientoSocio
        public ActionResult Index()
        {
            var reslt = dbContext.SocioModel.Select(e=>e);
            return View(reslt);
        }

        // GET: MantenimientoSocio/Details/5
        public ActionResult Details(int id)
        {
          
            return View(Test);
        }

        // GET: MantenimientoSocio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MantenimientoSocio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MantenimientoSocio/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Test);
        }

        // POST: MantenimientoSocio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MantenimientoSocio/Delete/5
        public ActionResult Delete(int id)
        {

            
            return View();
        }

        // POST: MantenimientoSocio/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
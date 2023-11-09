using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MensajesAlertas.Controllers
{
    public class Persona
    {
        public string Nombre { get; set; }
    }

    public class HomeController : Controller
    {
        Persona p = new Persona();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Nombre)
        {
            
            p.Nombre = Nombre;

            return RedirectToAction("Completado", "Home", new {p.Nombre});
        }

        public ActionResult Completado(Persona p) 
        {
            //this.p = p;
            return View(p);
        }
    }
}
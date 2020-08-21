using Diplomado_MVC_HTML_Helps_Persona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diplomado_MVC_HTML_Helps_Persona.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(FormCollection coleccion)
        {
            // si el codigo viene vacio, retornamos al Index
            if (coleccion["Codigo"].ToString() == "")
                return RedirectToAction("Index");
            MantenimientoPersonas m = new MantenimientoPersonas();
            Persona per = m.Retornar(int.Parse(coleccion["Codigo"].ToString()));
            if (per != null)
                return View("EditarPersona",per);
            else            
                return RedirectToAction("Index");
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
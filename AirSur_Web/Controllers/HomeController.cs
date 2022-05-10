using Airsur.LogicaDeNegocio;
using AirSur.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirSur_Web.Controllers
{
    public class HomeController : Controller
    {
        SoldadoBL metodosNegocio = new SoldadoBL();

        public IEnumerable<Soldado> soldados { get; set; }

        public ActionResult Index()
        {
            var soldados = metodosNegocio.obtenerListaSoldados();
            return View();
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
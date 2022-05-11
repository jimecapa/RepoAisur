using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AirSur.AccesoADatos;

namespace AirSur_Web.Controllers
{
    public class VehiculoController : Controller        
    {
        private bdaisurEntities db = new bdaisurEntities();

        // GET: Vehiculo
        public ActionResult Index()
        {
            var vehiculo = db.vehiculo.Include(v => v.marca).Include(v => v.tipoVehiculo);
            return View(vehiculo.ToList());
        }

        // GET: armas/Create
        public ActionResult Create()
        {
            ViewBag.IdMarca_Fk = new SelectList(db.marca, "id_marca", "nombre");
            ViewBag.IdTipoVehiculo_Fk = new SelectList(db.tipoVehiculo, "id_tipoVehiculo", "nombre");
            return View();
        }

        // POST: Vehiculo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_vehiculo,nombre,cilindraje,capacidadCargaMunicion,idTipoVehiculo_Fk,idMarca_Fk")] vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                db.vehiculo.Add(vehiculo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMarca_Fk = new SelectList(db.marca, "id_marca", "nombre", vehiculo.idMarca_Fk);
            ViewBag.idTipoVehiculo_Fk = new SelectList(db.tipoVehiculo, "id_tipoVehiculo", "nombre", vehiculo.idTipoVehiculo_Fk);
            return View(vehiculo);
        }
    }
}
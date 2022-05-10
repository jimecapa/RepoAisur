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
    public class armasController : Controller
    {
        private bdaisurEntities db = new bdaisurEntities();

        // GET: armas
        public ActionResult Index()
        {
            var arma = db.arma.Include(a => a.marca).Include(a => a.tipoArma);
            return View(arma.ToList());
        }

        // GET: armas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arma arma = db.arma.Find(id);
            if (arma == null)
            {
                return HttpNotFound();
            }
            return View(arma);
        }

        // GET: armas/Create
        public ActionResult Create()
        {
            ViewBag.IdMarca_Fk = new SelectList(db.marca, "id_marca", "nombre");
            ViewBag.IdTipoArma_Fk = new SelectList(db.tipoArma, "id_tipoArma", "nombre");
            return View();
        }

        // POST: armas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_arma,nombre,peso,cantidadMunicion,IdTipoArma_Fk,IdMarca_Fk")] arma arma)
        {
            if (ModelState.IsValid)
            {
                db.arma.Add(arma);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMarca_Fk = new SelectList(db.marca, "id_marca", "nombre", arma.IdMarca_Fk);
            ViewBag.IdTipoArma_Fk = new SelectList(db.tipoArma, "id_tipoArma", "nombre", arma.IdTipoArma_Fk);
            return View(arma);
        }

        // GET: armas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arma arma = db.arma.Find(id);
            if (arma == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMarca_Fk = new SelectList(db.marca, "id_marca", "nombre", arma.IdMarca_Fk);
            ViewBag.IdTipoArma_Fk = new SelectList(db.tipoArma, "id_tipoArma", "nombre", arma.IdTipoArma_Fk);
            return View(arma);
        }

        // POST: armas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_arma,nombre,peso,cantidadMunicion,IdTipoArma_Fk,IdMarca_Fk")] arma arma)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arma).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdMarca_Fk = new SelectList(db.marca, "id_marca", "nombre", arma.IdMarca_Fk);
            ViewBag.IdTipoArma_Fk = new SelectList(db.tipoArma, "id_tipoArma", "nombre", arma.IdTipoArma_Fk);
            return View(arma);
        }

        // GET: armas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arma arma = db.arma.Find(id);
            if (arma == null)
            {
                return HttpNotFound();
            }
            return View(arma);
        }

        // POST: armas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            arma arma = db.arma.Find(id);
            db.arma.Remove(arma);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

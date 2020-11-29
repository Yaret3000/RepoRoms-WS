using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RepoRomsWS.Models;

namespace RepoRomsWS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ConsolasController : Controller
    {
        private RomsContext db = new RomsContext();
        [AllowAnonymous]
        // GET: Consolas
        public ActionResult Index()
        {
            return View(db.Consolas.ToList());
        }
        [AllowAnonymous]
        // GET: Consolas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consola consola = db.Consolas.Find(id);
            if (consola == null)
            {
                return HttpNotFound();
            }
            return View(consola);
        }


        // GET: Consolas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consolas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,cover,fecha")] Consola consola)
        {
            if (ModelState.IsValid)
            {
                db.Consolas.Add(consola);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consola);
        }

        // GET: Consolas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consola consola = db.Consolas.Find(id);
            if (consola == null)
            {
                return HttpNotFound();
            }
            return View(consola);
        }

        // POST: Consolas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,cover,fecha")] Consola consola)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consola).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consola);
        }

        // GET: Consolas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consola consola = db.Consolas.Find(id);
            if (consola == null)
            {
                return HttpNotFound();
            }
            return View(consola);
        }

        // POST: Consolas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Consola consola = db.Consolas.Find(id);
            db.Consolas.Remove(consola);
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

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
    public class EmusController : Controller
    {
        private RomsContext db = new RomsContext();

        [AllowAnonymous]
        // GET: Emus
        public ActionResult Index()
        {
            var emus = db.Emus.Include(e => e.Consola).Include(e => e.Plataforma);
            return View(emus.ToList());
        }

        [AllowAnonymous]
        // GET: Emus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emu emu = db.Emus.Find(id);
            if (emu == null)
            {
                return HttpNotFound();
            }
            return View(emu);
        }

        // GET: Emus/Create
        public ActionResult Create()
        {
            ViewBag.consolaId = new SelectList(db.Consolas, "id", "nombre");
            ViewBag.PlataformaId = new SelectList(db.Plataformas, "id", "nombre");
            return View();
        }

        // POST: Emus/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,info,cover,consolaId,PlataformaId")] Emu emu)
        {
            if (ModelState.IsValid)
            {
                db.Emus.Add(emu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.consolaId = new SelectList(db.Consolas, "id", "nombre", emu.consolaId);
            ViewBag.PlataformaId = new SelectList(db.Plataformas, "id", "nombre", emu.PlataformaId);
            return View(emu);
        }

        // GET: Emus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emu emu = db.Emus.Find(id);
            if (emu == null)
            {
                return HttpNotFound();
            }
            ViewBag.consolaId = new SelectList(db.Consolas, "id", "nombre", emu.consolaId);
            ViewBag.PlataformaId = new SelectList(db.Plataformas, "id", "nombre", emu.PlataformaId);
            return View(emu);
        }

        // POST: Emus/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,info,cover,consolaId,PlataformaId")] Emu emu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.consolaId = new SelectList(db.Consolas, "id", "nombre", emu.consolaId);
            ViewBag.PlataformaId = new SelectList(db.Plataformas, "id", "nombre", emu.PlataformaId);
            return View(emu);
        }

        // GET: Emus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emu emu = db.Emus.Find(id);
            if (emu == null)
            {
                return HttpNotFound();
            }
            return View(emu);
        }

        // POST: Emus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emu emu = db.Emus.Find(id);
            db.Emus.Remove(emu);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using RepoRomsWS.Models;

namespace RepoRomsWS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RomsController : Controller
    {
        private RomsContext db = new RomsContext();

        [AllowAnonymous]
        // GET: Roms
        public ActionResult Index()
        {
            var roms = db.Roms.Include(r => r.Consola);
            return View(roms.ToList());
        }

        [AllowAnonymous]
        // GET: Roms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rom rom = db.Roms.Find(id);
            if (rom == null)
            {
                return HttpNotFound();
            }
            return View(rom);
        }

        // GET: Roms/Create
        public ActionResult Create()
        {
            ViewBag.consolaId = new SelectList(db.Consolas, "id", "nombre");
            return View();
        }

        // POST: Roms/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,sinopsis,cover,fecha,video,consolaId")] Rom rom)
        {
            if (ModelState.IsValid)
            {
                db.Roms.Add(rom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.consolaId = new SelectList(db.Consolas, "id", "nombre", rom.consolaId);
            return View(rom);
        }

        // GET: Roms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rom rom = db.Roms.Find(id);
            if (rom == null)
            {
                return HttpNotFound();
            }
            ViewBag.consolaId = new SelectList(db.Consolas, "id", "nombre", rom.consolaId);
            return View(rom);
        }

        // POST: Roms/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,sinopsis,cover,fecha,video,consolaId")] Rom rom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.consolaId = new SelectList(db.Consolas, "id", "nombre", rom.consolaId);
            return View(rom);
        }

        // GET: Roms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rom rom = db.Roms.Find(id);
            if (rom == null)
            {
                return HttpNotFound();
            }
            return View(rom);
        }

        // POST: Roms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rom rom = db.Roms.Find(id);
            db.Roms.Remove(rom);
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

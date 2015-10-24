using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Plan.Models;

namespace Plan.Controllers
{
    public class GrupyController : Controller
    {
        private PlanDbContext db = new PlanDbContext();

        // GET: Grupy
        public ActionResult Index()
        {
            return View(db.Grupy.ToList());
        }

        // GET: Grupy/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupa grupa = db.Grupy.Find(id);
            if (grupa == null)
            {
                return HttpNotFound();
            }
            return View(grupa);
        }

        // GET: Grupy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grupy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NumerGrupy")] Grupa grupa)
        {
            if (ModelState.IsValid)
            {
                db.Grupy.Add(grupa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grupa);
        }

        // GET: Grupy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupa grupa = db.Grupy.Find(id);
            if (grupa == null)
            {
                return HttpNotFound();
            }
            return View(grupa);
        }

        // POST: Grupy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NumerGrupy")] Grupa grupa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grupa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grupa);
        }

        // GET: Grupy/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupa grupa = db.Grupy.Find(id);
            if (grupa == null)
            {
                return HttpNotFound();
            }
            return View(grupa);
        }

        // POST: Grupy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grupa grupa = db.Grupy.Find(id);
            db.Grupy.Remove(grupa);
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

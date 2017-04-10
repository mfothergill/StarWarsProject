using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class DroidsController : Controller
    {
        private WebApplication6Context db = new WebApplication6Context();

        // GET: Droids
        public ActionResult Index()
        {
            return View(db.Droids.ToList());
        }

        // GET: Droids/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Droids droids = db.Droids.Find(id);
            if (droids == null)
            {
                return HttpNotFound();
            }
            return View(droids);
        }

        // GET: Droids/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Droids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DroidName,DroidClass,Accuracy,MovementRating,RequiresLevel5ProgrammingAbility,ReviewofDroid")] Droids droids)
        {
            if (ModelState.IsValid)
            {
                db.Droids.Add(droids);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(droids);
        }

        // GET: Droids/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Droids droids = db.Droids.Find(id);
            if (droids == null)
            {
                return HttpNotFound();
            }
            return View(droids);
        }

        // POST: Droids/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DroidName,DroidClass,Accuracy,MovementRating,RequiresLevel5ProgrammingAbility,ReviewofDroid")] Droids droids)
        {
            if (ModelState.IsValid)
            {
                db.Entry(droids).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(droids);
        }

        // GET: Droids/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Droids droids = db.Droids.Find(id);
            if (droids == null)
            {
                return HttpNotFound();
            }
            return View(droids);
        }

        // POST: Droids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Droids droids = db.Droids.Find(id);
            db.Droids.Remove(droids);
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

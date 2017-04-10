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
    public class LightSabersController : Controller
    {
        private WebApplication6Context db = new WebApplication6Context();

        // GET: LightSabers
        public ActionResult Index()
        {
            return View(db.LightSabers.ToList());
        }

        // GET: LightSabers/Details/5
        public ActionResult Details(bool? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LightSabers lightSabers = db.LightSabers.Find(id);
            if (lightSabers == null)
            {
                return HttpNotFound();
            }
            return View(lightSabers);
        }

        // GET: LightSabers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LightSabers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AvailableForDarksideOnly,SaberType,SaberColor,SaberLength,LightSaberReview")] LightSabers lightSabers)
        {
            if (ModelState.IsValid)
            {
                db.LightSabers.Add(lightSabers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lightSabers);
        }

        // GET: LightSabers/Edit/5
        public ActionResult Edit(bool? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LightSabers lightSabers = db.LightSabers.Find(id);
            if (lightSabers == null)
            {
                return HttpNotFound();
            }
            return View(lightSabers);
        }

        // POST: LightSabers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AvailableForDarksideOnly,SaberType,SaberColor,SaberLength,LightSaberReview")] LightSabers lightSabers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lightSabers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lightSabers);
        }

        // GET: LightSabers/Delete/5
        public ActionResult Delete(bool? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LightSabers lightSabers = db.LightSabers.Find(id);
            if (lightSabers == null)
            {
                return HttpNotFound();
            }
            return View(lightSabers);
        }

        // POST: LightSabers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(bool id)
        {
            LightSabers lightSabers = db.LightSabers.Find(id);
            db.LightSabers.Remove(lightSabers);
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

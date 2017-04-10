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
    public class ShipsController : Controller
    {
        private WebApplication6Context db = new WebApplication6Context();

        // GET: Ships
        public ActionResult Index()
        {
            return View(db.Ships.ToList());
        }

        // GET: Ships/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ships ships = db.Ships.Find(id);
            if (ships == null)
            {
                return HttpNotFound();
            }
            return View(ships);
        }

        // GET: Ships/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShipName,ShipType,MainWeapons,SecondaryWeapons,EquippedWithShield,ShipReview")] Ships ships)
        {
            if (ModelState.IsValid)
            {
                db.Ships.Add(ships);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ships);
        }

        // GET: Ships/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ships ships = db.Ships.Find(id);
            if (ships == null)
            {
                return HttpNotFound();
            }
            return View(ships);
        }

        // POST: Ships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShipName,ShipType,MainWeapons,SecondaryWeapons,EquippedWithShield,ShipReview")] Ships ships)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ships).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ships);
        }

        // GET: Ships/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ships ships = db.Ships.Find(id);
            if (ships == null)
            {
                return HttpNotFound();
            }
            return View(ships);
        }

        // POST: Ships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ships ships = db.Ships.Find(id);
            db.Ships.Remove(ships);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using jg739415MIS4200.DAL;
using jg739415MIS4200.Models;

namespace jg739415MIS4200.Controllers
{
    public class VehicleDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: VehicleDetails
        public ActionResult Index()
        {
            var vehicleDetails = db.VehicleDetails.Include(v => v.Seller);
            return View(vehicleDetails.ToList());
        }

        // GET: VehicleDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleDetails vehicleDetails = db.VehicleDetails.Find(id);
            if (vehicleDetails == null)
            {
                return HttpNotFound();
            }
            return View(vehicleDetails);
        }

        // GET: VehicleDetails/Create
        public ActionResult Create()
        {
            ViewBag.sellerID = new SelectList(db.Sellers, "sellerID", "sellerName");
            return View();
        }

        // POST: VehicleDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vehicleDetailsID,make,model,year,vehicleID,sellerID")] VehicleDetails vehicleDetails)
        {
            if (ModelState.IsValid)
            {
                db.VehicleDetails.Add(vehicleDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.sellerID = new SelectList(db.Sellers, "sellerId", "sellerName", vehicleDetails.sellerID);
            return View(vehicleDetails);
        }

        // GET: VehicleDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleDetails vehicleDetails = db.VehicleDetails.Find(id);
            if (vehicleDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.sellerID = new SelectList(db.Sellers, "sellerId", "sellerName", vehicleDetails.sellerID);
            return View(vehicleDetails);
        }

        // POST: VehicleDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vehicleDetailsID,make,model,year,vehicleID,sellerID")] VehicleDetails vehicleDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicleDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.sellerID = new SelectList(db.Sellers, "sellerId", "sellerName", vehicleDetails.sellerID);
            return View(vehicleDetails);
        }

        // GET: VehicleDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleDetails vehicleDetails = db.VehicleDetails.Find(id);
            if (vehicleDetails == null)
            {
                return HttpNotFound();
            }
            return View(vehicleDetails);
        }

        // POST: VehicleDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VehicleDetails vehicleDetails = db.VehicleDetails.Find(id);
            db.VehicleDetails.Remove(vehicleDetails);
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

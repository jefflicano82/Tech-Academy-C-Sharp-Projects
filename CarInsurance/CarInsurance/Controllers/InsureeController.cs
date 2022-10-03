using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                CalculateQuote(insuree.Id);
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
        public ActionResult CalculateQuote(int Id)
        {
            
                var insuree = db.Insurees.Find(Id);
                var dateOfBirth = insuree.DateOfBirth;
                var carYear = insuree.CarYear;
                var carModel = insuree.CarModel;
                var carMake = insuree.CarMake;
                var speedingTickets = insuree.SpeedingTickets;
                var dui = insuree.DUI;
                var coverageType = insuree.CoverageType;

                var age = DateTime.Today.Year - dateOfBirth.Year; 
                
                var quote = 50.0M;

                if (age<=18)
                {
                    quote = quote + 100.00M;
                }
                else if (age>=19 && age <=25)
                {
                    quote = quote + 50.0M;
                }
                else if (age>=26)
                {
                    quote = quote + 25.0M;
                }

                if (carYear < 2000)
                {
                    quote = quote + 25.0M;
                }
                else if (carYear > 2015)
                {
                    quote = quote + 25.0M;
                }

                if (carMake == "Porsche")
                {
                    quote = quote + 25.0M;
                }

                if (carMake == "Porsche" && carModel == "911 Carrera")
                {
                    quote = quote + 25M;
                }
                
                if (speedingTickets > 0)
            {
                quote = quote + (speedingTickets * 10.0M);
            }
                

                if (dui == true)
                {
                    quote = quote + (quote / 4.0M);
                }

                if (coverageType == true)
                {
                    quote = quote + (quote / 2.0M);
                }
            db.SaveChanges();
            return RedirectToAction("Index");
           
            //return (int) quote;
        }
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
    }
    }
}

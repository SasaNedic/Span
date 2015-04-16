using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpanTest.Models;

namespace SpanTest.Controllers
{ 
    public class WorkerController : Controller
    {
        private WorkerContext db = new WorkerContext();

        //
        // GET: /Worker/

        public ViewResult Index()
        {
            return View(db.Workers.ToList());
        }

        //
        // GET: /Worker/Details/5

        public ViewResult Details(int id)
        {
            Worker worker = db.Workers.Find(id);
            return View(worker);
        }

        //
        // GET: /Worker/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Worker/Create

        [HttpPost]
        public ActionResult Create(Worker worker)
        {
            if (ModelState.IsValid)
            {
                db.Workers.Add(worker);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(worker);
        }
        
        //
        // GET: /Worker/Edit/5
 
        public ActionResult Edit(int id)
        {
            Worker worker = db.Workers.Find(id);
            return View(worker);
        }

        //
        // POST: /Worker/Edit/5

        [HttpPost]
        public ActionResult Edit(Worker worker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(worker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(worker);
        }

        //
        // GET: /Worker/Delete/5
 
        public ActionResult Delete(int id)
        {
            Worker worker = db.Workers.Find(id);
            return View(worker);
        }

        //
        // POST: /Worker/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Worker worker = db.Workers.Find(id);
            db.Workers.Remove(worker);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
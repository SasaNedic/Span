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
    public class NalogDBEntryController : Controller
    {
        private NalogDBEntryContext db = new NalogDBEntryContext();

        //
        // GET: /NalogDBEntry/

        public ViewResult Index()
        {
            return View(db.NalogDBEntrys.ToList());
        }

        //
        // GET: /NalogDBEntry/Details/5

        public ViewResult Details(int id)
        {
            NalogDBEntry nalogdbentry = db.NalogDBEntrys.Find(id);
            return View(nalogdbentry);
        }

        //
        // GET: /NalogDBEntry/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /NalogDBEntry/Create

        [HttpPost]
        public ActionResult Create(NalogDBEntry nalogdbentry)
        {
            if (ModelState.IsValid)
            {
                db.NalogDBEntrys.Add(nalogdbentry);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(nalogdbentry);
        }
        
        //
        // GET: /NalogDBEntry/Edit/5
 
        public ActionResult Edit(int id)
        {
            NalogDBEntry nalogdbentry = db.NalogDBEntrys.Find(id);
            return View(nalogdbentry);
        }

        //
        // POST: /NalogDBEntry/Edit/5

        [HttpPost]
        public ActionResult Edit(NalogDBEntry nalogdbentry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nalogdbentry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nalogdbentry);
        }

        //
        // GET: /NalogDBEntry/Delete/5
 
        public ActionResult Delete(int id)
        {
            NalogDBEntry nalogdbentry = db.NalogDBEntrys.Find(id);
            return View(nalogdbentry);
        }

        //
        // POST: /NalogDBEntry/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            NalogDBEntry nalogdbentry = db.NalogDBEntrys.Find(id);
            db.NalogDBEntrys.Remove(nalogdbentry);
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
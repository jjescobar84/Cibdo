using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cibdo.Models;

namespace Cibdo.Controllers
{
    public class ReminderTypesController : Controller
    {
        private CibdoContext db = new CibdoContext();

        // GET: ReminderTypes
        public ActionResult Index()
        {
            return View(db.ReminderTypes.ToList());
        }

        // GET: ReminderTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReminderType reminderType = db.ReminderTypes.Find(id);
            if (reminderType == null)
            {
                return HttpNotFound();
            }
            return View(reminderType);
        }

        // GET: ReminderTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReminderTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tipoRecordatorioId,nombre")] ReminderType reminderType)
        {
            if (ModelState.IsValid)
            {
                db.ReminderTypes.Add(reminderType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reminderType);
        }

        // GET: ReminderTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReminderType reminderType = db.ReminderTypes.Find(id);
            if (reminderType == null)
            {
                return HttpNotFound();
            }
            return View(reminderType);
        }

        // POST: ReminderTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tipoRecordatorioId,nombre")] ReminderType reminderType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reminderType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reminderType);
        }

        // GET: ReminderTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReminderType reminderType = db.ReminderTypes.Find(id);
            if (reminderType == null)
            {
                return HttpNotFound();
            }
            return View(reminderType);
        }

        // POST: ReminderTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReminderType reminderType = db.ReminderTypes.Find(id);
            db.ReminderTypes.Remove(reminderType);
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

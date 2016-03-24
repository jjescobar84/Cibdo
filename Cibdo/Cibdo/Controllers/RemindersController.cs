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
    public class RemindersController : Controller
    {
        private CibdoContext db = new CibdoContext();

        // GET: Reminders
        public ActionResult Index()
        {
            var reminders = db.Reminders.Include(r => r.ReminderType);
            return View(reminders.ToList());
        }

        // GET: Reminders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reminder reminder = db.Reminders.Find(id);
            if (reminder == null)
            {
                return HttpNotFound();
            }
            return View(reminder);
        }

        // GET: Reminders/Create
        public ActionResult Create()
        {
            ViewBag.tipoRecordatorioId = new SelectList(db.ReminderTypes, "tipoRecordatorioId", "nombre");
            return View();
        }

        // POST: Reminders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "recordatorioId,nombre,tipoRecordatorioId,descripcion,fecha,hora")] Reminder reminder)
        {
            if (ModelState.IsValid)
            {
                db.Reminders.Add(reminder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.tipoRecordatorioId = new SelectList(db.ReminderTypes, "tipoRecordatorioId", "nombre", reminder.tipoRecordatorioId);
            return View(reminder);
        }

        // GET: Reminders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reminder reminder = db.Reminders.Find(id);
            if (reminder == null)
            {
                return HttpNotFound();
            }
            ViewBag.tipoRecordatorioId = new SelectList(db.ReminderTypes, "tipoRecordatorioId", "nombre", reminder.tipoRecordatorioId);
            return View(reminder);
        }

        // POST: Reminders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "recordatorioId,nombre,tipoRecordatorioId,descripcion,fecha,hora")] Reminder reminder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reminder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.tipoRecordatorioId = new SelectList(db.ReminderTypes, "tipoRecordatorioId", "nombre", reminder.tipoRecordatorioId);
            return View(reminder);
        }

        // GET: Reminders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reminder reminder = db.Reminders.Find(id);
            if (reminder == null)
            {
                return HttpNotFound();
            }
            return View(reminder);
        }

        // POST: Reminders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reminder reminder = db.Reminders.Find(id);
            db.Reminders.Remove(reminder);
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

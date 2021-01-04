using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fbus.Models;

namespace fbus.Controllers
{
    public class AnswerEventsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: AnswerEvents
        public ActionResult Index()
        {
            return View(db.AnswerEvents.ToList());
        }

        // GET: AnswerEvents/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnswerEvent answerEvent = db.AnswerEvents.Find(id);
            if (answerEvent == null)
            {
                return HttpNotFound();
            }
            return View(answerEvent);
        }

        // GET: AnswerEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnswerEvents/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AnswerId,ClientTime,Answer")] AnswerEvent answerEvent)
        {
            if (ModelState.IsValid)
            {
                answerEvent.Id = Guid.NewGuid();
                db.AnswerEvents.Add(answerEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(answerEvent);
        }

        // GET: AnswerEvents/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnswerEvent answerEvent = db.AnswerEvents.Find(id);
            if (answerEvent == null)
            {
                return HttpNotFound();
            }
            return View(answerEvent);
        }

        // POST: AnswerEvents/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AnswerId,ClientTime,Answer")] AnswerEvent answerEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(answerEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(answerEvent);
        }

        // GET: AnswerEvents/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnswerEvent answerEvent = db.AnswerEvents.Find(id);
            if (answerEvent == null)
            {
                return HttpNotFound();
            }
            return View(answerEvent);
        }

        // POST: AnswerEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            AnswerEvent answerEvent = db.AnswerEvents.Find(id);
            db.AnswerEvents.Remove(answerEvent);
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

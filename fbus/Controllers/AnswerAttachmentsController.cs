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
    public class AnswerAttachmentsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: AnswerAttachments
        public ActionResult Index()
        {
            return View(db.AnswerAttachments.ToList());
        }

        // GET: AnswerAttachments/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnswerAttachment answerAttachment = db.AnswerAttachments.Find(id);
            if (answerAttachment == null)
            {
                return HttpNotFound();
            }
            return View(answerAttachment);
        }

        // GET: AnswerAttachments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnswerAttachments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AnswerId,Created,FileName,MimeType,Size")] AnswerAttachment answerAttachment)
        {
            if (ModelState.IsValid)
            {
                answerAttachment.Id = Guid.NewGuid();
                db.AnswerAttachments.Add(answerAttachment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(answerAttachment);
        }

        // GET: AnswerAttachments/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnswerAttachment answerAttachment = db.AnswerAttachments.Find(id);
            if (answerAttachment == null)
            {
                return HttpNotFound();
            }
            return View(answerAttachment);
        }

        // POST: AnswerAttachments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AnswerId,Created,FileName,MimeType,Size")] AnswerAttachment answerAttachment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(answerAttachment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(answerAttachment);
        }

        // GET: AnswerAttachments/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnswerAttachment answerAttachment = db.AnswerAttachments.Find(id);
            if (answerAttachment == null)
            {
                return HttpNotFound();
            }
            return View(answerAttachment);
        }

        // POST: AnswerAttachments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            AnswerAttachment answerAttachment = db.AnswerAttachments.Find(id);
            db.AnswerAttachments.Remove(answerAttachment);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PeerReviewSystem.Models;
using EntityState = System.Data.Entity.EntityState;

namespace PeerReviewSystem.Control
{
    public class ReviewsController : Controller
    {
        private ReviewDbContext db = new ReviewDbContext();

        // GET: Reviews
        public ActionResult Index()
        {
            var reviews = db.Reviews.Include(r => r.Project).Include(r => r.ProjectLead).Include(r => r.Questions).Include(r => r.Rating).Include(r => r.Reviewee).Include(r => r.Reviewer);
            return View(reviews.ToList());
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            ViewBag.reviewID = new SelectList(db.Projects, "projectID", "Name");
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name");
            ViewBag.reviewID = new SelectList(db.Questions, "questionID", "Question");
            ViewBag.reviewID = new SelectList(db.Responses, "rateID", "rating");
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name");
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name");
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "reviewID,ReviewDate")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.reviewID = new SelectList(db.Projects, "projectID", "Name", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Questions, "questionID", "Question", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Responses, "rateID", "rating", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name", review.reviewID);
            return View(review);
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            ViewBag.reviewID = new SelectList(db.Projects, "projectID", "Name", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Questions, "questionID", "Question", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Responses, "rateID", "rating", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name", review.reviewID);
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "reviewID,ReviewDate")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.reviewID = new SelectList(db.Projects, "projectID", "Name", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Questions, "questionID", "Question", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Responses, "rateID", "rating", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name", review.reviewID);
            ViewBag.reviewID = new SelectList(db.Employees, "empID", "Name", review.reviewID);
            return View(review);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = db.Reviews.Find(id);
            db.Reviews.Remove(review);
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

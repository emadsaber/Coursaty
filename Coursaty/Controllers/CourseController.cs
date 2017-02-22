using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coursaty.Models;

namespace Coursaty.Controllers
{
    public class CourseController : Controller
    {
        private CoursatyEntities db = new CoursatyEntities();

        //
        // GET: /Course/

        public ActionResult Index()
        {
            var courses = db.Courses.Include(c => c.Instructor).Include(c => c.Track);
            return View(courses.ToList());
        }

        //
        // GET: /Course/Details/5

        public ActionResult Details(int id = 0)
        {
            Course course = db.Courses.Find(id);
            try
            {
                course.views += 1;
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                this.ModelState.AddModelError("Increment Views", ex);
            }
            if (course == null)
            {
                return HttpNotFound();
            }
            if(course.Track != null && course.Track.name != null) ViewData["TrackName"] = course.Track.name;
            if (course.Instructor != null && course.Instructor.name != null) ViewData["InstructorName"] = course.Instructor.name;
            return View(course);
        }

        //
        // GET: /Course/Create

        public ActionResult Create()
        {
            ViewBag.instructorId = new SelectList(db.Instructors, "id", "name");
            ViewBag.trackId = new SelectList(db.Tracks, "id", "name");
            return View();
        }

        //
        // POST: /Course/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.instructorId = new SelectList(db.Instructors, "id", "name", course.instructorId);
            ViewBag.trackId = new SelectList(db.Tracks, "id", "name", course.trackId);
            return View(course);
        }

        //
        // GET: /Course/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            ViewBag.instructorId = new SelectList(db.Instructors, "id", "name", course.instructorId);
            ViewBag.trackId = new SelectList(db.Tracks, "id", "name", course.trackId);
            return View(course);
        }

        //
        // POST: /Course/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.instructorId = new SelectList(db.Instructors, "id", "name", course.instructorId);
            ViewBag.trackId = new SelectList(db.Tracks, "id", "name", course.trackId);
            return View(course);
        }

        //
        // GET: /Course/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        //
        // POST: /Course/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
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
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coursaty.Models;

namespace Coursaty.Controllers
{
    public class TrackController : Controller
    {
        private CoursatyEntities db = new CoursatyEntities();

        //
        // GET: /Track/

        public ActionResult Index()
        {
            var tracks = db.Tracks.Include(t => t.Track1);
            return View(tracks.ToList());
        }

        //
        // GET: /Track/Details/5

        public ActionResult Details(int id = 0)
        {
            Track track = db.Tracks.Find(id);
            if (track == null)
            {
                return HttpNotFound();
            }
            return View(track);
        }

        //
        // GET: /Track/Create

        public ActionResult Create()
        {
            ViewBag.parentTrack = new SelectList(db.Tracks, "id", "name");
            return View();
        }

        //
        // POST: /Track/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Track track)
        {
            if (ModelState.IsValid)
            {
                db.Tracks.Add(track);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.parentTrack = new SelectList(db.Tracks, "id", "name", track.parentTrack);
            return View(track);
        }

        //
        // GET: /Track/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Track track = db.Tracks.Find(id);
            if (track == null)
            {
                return HttpNotFound();
            }
            ViewBag.parentTrack = new SelectList(db.Tracks, "id", "name", track.parentTrack);
            return View(track);
        }

        //
        // POST: /Track/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Track track)
        {
            if (ModelState.IsValid)
            {
                db.Entry(track).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.parentTrack = new SelectList(db.Tracks, "id", "name", track.parentTrack);
            return View(track);
        }

        //
        // GET: /Track/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Track track = db.Tracks.Find(id);
            if (track == null)
            {
                return HttpNotFound();
            }
            return View(track);
        }

        //
        // POST: /Track/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Track track = db.Tracks.Find(id);
            db.Tracks.Remove(track);
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
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Veri_Tabani_Odevi.Models;

namespace Veri_Tabani_Odevi.Controllers
{
    public class MulakatController : Controller
    {
        private StajContext db = new StajContext();

        // GET: Mulakat
        public ActionResult Index()
        {
            return View(db.Mulakatlar.ToList());
        }

        // GET: Mulakat/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mulakat mulakat = db.Mulakatlar.Find(id);
            if (mulakat == null)
            {
                return HttpNotFound();
            }
            return View(mulakat);
        }

        // GET: Mulakat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mulakat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MulakatId,MulakatTarihi,MulakatSaati,MulakatYeri")] Mulakat mulakat)
        {
            if (ModelState.IsValid)
            {
                db.Mulakatlar.Add(mulakat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mulakat);
        }

        // GET: Mulakat/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mulakat mulakat = db.Mulakatlar.Find(id);
            if (mulakat == null)
            {
                return HttpNotFound();
            }
            return View(mulakat);
        }

        // POST: Mulakat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MulakatId,OgrenciNo,OgrenciAdi,OgrenciSoyadi,OgrenciSinif,OgrenciOgretim,MulakatTarihi,MulakatSaati,MulakatYeri")] Mulakat mulakat)
        {
            if (ModelState.IsValid)
            {
                var entity = db.Mulakatlar.Find(mulakat.MulakatId);
                {
                    entity.OgrenciNo = mulakat.OgrenciNo;
                    entity.OgrenciAdi = mulakat.OgrenciAdi;
                    entity.OgrenciSoyadi = mulakat.OgrenciSoyadi;
                    entity.OgrenciSinif = mulakat.OgrenciSinif;
                    entity.OgrenciOgretim = mulakat.OgrenciOgretim;
                    entity.MulakatTarihi = mulakat.MulakatTarihi;
                    entity.MulakatSaati = mulakat.MulakatSaati;
                    entity.MulakatYeri = mulakat.MulakatYeri;

                    db.SaveChanges();
                    TempData["Mulakat"] = entity;

                    return RedirectToAction("Index");
                }
            }
            return View(mulakat);
        }
            // GET: Mulakat/Delete/5
            public ActionResult Delete(int? id)
            {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mulakat mulakat = db.Mulakatlar.Find(id);
            if (mulakat == null)
            {
                return HttpNotFound();
            }
            return View(mulakat);
        }

        // POST: Mulakat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mulakat mulakat = db.Mulakatlar.Find(id);
            db.Mulakatlar.Remove(mulakat);
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

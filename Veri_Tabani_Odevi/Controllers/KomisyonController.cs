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
    public class KomisyonController : Controller
    {
        private StajContext db = new StajContext();

        // GET: Komisyons
        public ActionResult Index()
        {
            return View(db.Komisyonlar.ToList());
        }

        // GET: Komisyons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Komisyon komisyon = db.Komisyonlar.Find(id);
            if (komisyon == null)
            {
                return HttpNotFound();
            }
            return View(komisyon);
        }

        // GET: Komisyons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Komisyons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KomisyonId,KomisyonUye1Ad,KomisyonUye1Soyad,KomisyonUye2Ad,KomisyonUye2Soyad,MulakatNo")] Komisyon komisyon)
        {
            if (ModelState.IsValid)
            {
                db.Komisyonlar.Add(komisyon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(komisyon);
        }

        // GET: Komisyons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Komisyon komisyon = db.Komisyonlar.Find(id);
            if (komisyon == null)
            {
                return HttpNotFound();
            }
            return View(komisyon);
        }

        // POST: Komisyons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KomisyonId,OgrenciNo,OgrenciAdi,OgrenciSoyadi,KomisyonUye1Ad,KomisyonUye1Soyad,KomisyonUye2Ad,KomisyonUye2Soyad,MulakatNo")] Komisyon komisyon)
        {
            if (ModelState.IsValid)
            {
                var entity = db.Komisyonlar.Find(komisyon.KomisyonId);
                {
                    entity.OgrenciNo = komisyon.OgrenciNo;
                    entity.OgrenciAdi = komisyon.OgrenciAdi;
                    entity.OgrenciSoyadi = komisyon.OgrenciSoyadi;
                    entity.KomisyonUye1Ad = komisyon.KomisyonUye1Ad;
                    entity.KomisyonUye1Soyad = komisyon.KomisyonUye1Soyad;
                    entity.KomisyonUye2Ad = komisyon.KomisyonUye2Ad;
                    entity.KomisyonUye2Soyad = komisyon.KomisyonUye2Soyad;
                    db.SaveChanges();

                    TempData["Komisyon"] = entity;
                    return RedirectToAction("Index");
                }
                
            }
            return View(komisyon);
        }

        // GET: Komisyons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Komisyon komisyon = db.Komisyonlar.Find(id);
            if (komisyon == null)
            {
                return HttpNotFound();
            }
            return View(komisyon);
        }

        // POST: Komisyons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Komisyon komisyon = db.Komisyonlar.Find(id);
            db.Komisyonlar.Remove(komisyon);
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

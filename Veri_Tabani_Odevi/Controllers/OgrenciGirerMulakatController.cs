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
    public class OgrenciGirerMulakatController : Controller
    {
        private StajContext db = new StajContext();

        // GET: OgrenciGirerMulakat
        public ActionResult Index()
        {
            var ogrenciGirerMulakat = db.OgrenciGirerMulakat.Include(o => o.Mulakat).Include(o => o.Ogrenci);
            return View(ogrenciGirerMulakat.ToList());
        }

        // GET: OgrenciGirerMulakat/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OgrenciGirerMulakat ogrenciGirerMulakat = db.OgrenciGirerMulakat.Find(id);
            if (ogrenciGirerMulakat == null)
            {
                return HttpNotFound();
            }
            return View(ogrenciGirerMulakat);
        }

        // GET: OgrenciGirerMulakat/Create
        public ActionResult Create()
        {
            ViewBag.MulakatId = new SelectList(db.Mulakatlar, "MulakatId", "MulakatYeri");
            ViewBag.OgrenciId = new SelectList(db.Ogrenciler, "OgrenciId", "OgrenciAdi");
            return View();
        }

        // POST: OgrenciGirerMulakat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OgrenciGirerMülakatId,OgrenciId,MulakatId")] OgrenciGirerMulakat ogrenciGirerMulakat)
        {
            if (ModelState.IsValid)
            {
                db.OgrenciGirerMulakat.Add(ogrenciGirerMulakat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MulakatId = new SelectList(db.Mulakatlar, "MulakatId", "MulakatYeri", ogrenciGirerMulakat.MulakatId);
            ViewBag.OgrenciId = new SelectList(db.Ogrenciler, "OgrenciId", "OgrenciAdi", ogrenciGirerMulakat.OgrenciId);
            return View(ogrenciGirerMulakat);
        }

        // GET: OgrenciGirerMulakat/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OgrenciGirerMulakat ogrenciGirerMulakat = db.OgrenciGirerMulakat.Find(id);
            if (ogrenciGirerMulakat == null)
            {
                return HttpNotFound();
            }
            ViewBag.MulakatId = new SelectList(db.Mulakatlar, "MulakatId", "MulakatYeri", ogrenciGirerMulakat.MulakatId);
            ViewBag.OgrenciId = new SelectList(db.Ogrenciler, "OgrenciId", "OgrenciAdi", ogrenciGirerMulakat.OgrenciId);
            return View(ogrenciGirerMulakat);
        }

        // POST: OgrenciGirerMulakat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OgrenciGirerMülakatId,OgrenciId,MulakatId")] OgrenciGirerMulakat ogrenciGirerMulakat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ogrenciGirerMulakat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MulakatId = new SelectList(db.Mulakatlar, "MulakatId", "MulakatYeri", ogrenciGirerMulakat.MulakatId);
            ViewBag.OgrenciId = new SelectList(db.Ogrenciler, "OgrenciId", "OgrenciAdi", ogrenciGirerMulakat.OgrenciId);
            return View(ogrenciGirerMulakat);
        }

        // GET: OgrenciGirerMulakat/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OgrenciGirerMulakat ogrenciGirerMulakat = db.OgrenciGirerMulakat.Find(id);
            if (ogrenciGirerMulakat == null)
            {
                return HttpNotFound();
            }
            return View(ogrenciGirerMulakat);
        }

        // POST: OgrenciGirerMulakat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OgrenciGirerMulakat ogrenciGirerMulakat = db.OgrenciGirerMulakat.Find(id);
            db.OgrenciGirerMulakat.Remove(ogrenciGirerMulakat);
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

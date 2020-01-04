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
    public class OgrenciYaparStajController : Controller
    {
        private StajContext db = new StajContext();

        // GET: OgrenciYaparStaj
        public ActionResult Index()
        {
            var ogrenciYaparStaj = db.OgrenciYaparStaj.Include(o => o.Ogrenci).Include(o => o.Staj);
            return View(ogrenciYaparStaj.ToList());
        }

        // GET: OgrenciYaparStaj/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OgrenciYaparStaj ogrenciYaparStaj = db.OgrenciYaparStaj.Find(id);
            if (ogrenciYaparStaj == null)
            {
                return HttpNotFound();
            }
            return View(ogrenciYaparStaj);
        }

        // GET: OgrenciYaparStaj/Create
        public ActionResult Create()
        {
            ViewBag.OgrenciId = new SelectList(db.Ogrenciler, "OgrenciId", "OgrenciAdi");
            ViewBag.StajId = new SelectList(db.Stajlar, "StajId", "KurumAdi");
            return View();
        }

        // POST: OgrenciYaparStaj/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OgrenciYaparStaj_Id,OgrenciId,StajId")] OgrenciYaparStaj ogrenciYaparStaj)
        {
            if (ModelState.IsValid)
            {
                db.OgrenciYaparStaj.Add(ogrenciYaparStaj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OgrenciId = new SelectList(db.Ogrenciler, "OgrenciId", "OgrenciAdi", ogrenciYaparStaj.OgrenciId);
            ViewBag.StajId = new SelectList(db.Stajlar, "StajId", "KurumAdi", ogrenciYaparStaj.StajId);
            return View(ogrenciYaparStaj);
        }

        // GET: OgrenciYaparStaj/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OgrenciYaparStaj ogrenciYaparStaj = db.OgrenciYaparStaj.Find(id);
            if (ogrenciYaparStaj == null)
            {
                return HttpNotFound();
            }
            ViewBag.OgrenciId = new SelectList(db.Ogrenciler, "OgrenciId", "OgrenciAdi", ogrenciYaparStaj.OgrenciId);
            ViewBag.StajId = new SelectList(db.Stajlar, "StajId", "KurumAdi", ogrenciYaparStaj.StajId);
            return View(ogrenciYaparStaj);
        }

        // POST: OgrenciYaparStaj/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OgrenciYaparStaj_Id,OgrenciId,StajId")] OgrenciYaparStaj ogrenciYaparStaj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ogrenciYaparStaj).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OgrenciId = new SelectList(db.Ogrenciler, "OgrenciId", "OgrenciAdi", ogrenciYaparStaj.OgrenciId);
            ViewBag.StajId = new SelectList(db.Stajlar, "StajId", "KurumAdi", ogrenciYaparStaj.StajId);
            return View(ogrenciYaparStaj);
        }

        // GET: OgrenciYaparStaj/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OgrenciYaparStaj ogrenciYaparStaj = db.OgrenciYaparStaj.Find(id);
            if (ogrenciYaparStaj == null)
            {
                return HttpNotFound();
            }
            return View(ogrenciYaparStaj);
        }

        // POST: OgrenciYaparStaj/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OgrenciYaparStaj ogrenciYaparStaj = db.OgrenciYaparStaj.Find(id);
            db.OgrenciYaparStaj.Remove(ogrenciYaparStaj);
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

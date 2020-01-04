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
    public class OgrenciController : Controller
    {
        private StajContext db = new StajContext();

        public object Ogrenciler { get; private set; }

       
        // GET: Ogrenci
        public ActionResult Index()
        {

            var ogrenciler = db.Ogrenciler
                .Select(i => new Ogrenci()
                {
                    OgrenciAdi=i.OgrenciAdi,
                    OgrenciSoyadi=i.OgrenciSoyadi,
                    OgrenciNo=i.OgrenciNo,
                    OgrenciOgretim=i.OgrenciOgretim,
                    OgrenciSinif=i.OgrenciSinif,
                    OgrenciResim=i.OgrenciResim,
                    DevamNotu=i.DevamNotu,
                    CabaVeCalismaNotu=i.CabaVeCalismaNotu,
                    IsıVaktindeBitirmeNotu=i.IsıVaktindeBitirmeNotu,
                    AmirineKarsiDavranisNotu=i.AmirineKarsiDavranisNotu,
                    IsArkadaslarinaKarsiDavranisNotu=i.IsArkadaslarinaKarsiDavranisNotu,
                    ProjeNotu=i.ProjeNotu,
                    DuzenNotu=i.DuzenNotu,
                    SunumNotu=i.SunumNotu,
                    IcerikNotu=i.IcerikNotu,
                    MulakatNotu=i.MulakatNotu,
                    HesaplananNotKatsayisi=i.HesaplananNotKatsayisi,
                    KabulEdilenGunSayisi=i.KabulEdilenGunSayisi,
                    KalanGünSayisi=i.KalanGünSayisi,
                    StajınTamamlanmaDurumu=i.StajınTamamlanmaDurumu,
                    
                }).OrderByDescending(i => i.HesaplananNotKatsayisi);

            return View(db.Ogrenciler.ToList());
        }

        //public ActionResult List(int? id, string OgrenciNumarası)
        //{
        //    var ogrenciler = db.Ogrenciler
        //        .Select(i => new Ogrenci()
        //        {
        //            OgrenciId = i.OgrenciId,
        //            OgrenciNo = i.OgrenciNo,
        //        }).AsQueryable();

        //    if (string.IsNullOrEmpty(OgrenciNumarası) == false)
        //    {
        //        var Ogrenciler = db.Ogrenciler.Where(i=>i.OgrenciNo);
        //    }
        //    return View(db.Ogrenciler.ToList());
        //}

        // GET: Ogrenci/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = db.Ogrenciler.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        // GET: Ogrenci/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ogrenci/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OgrenciId,OgrenciNo,OgrenciAdi,OgrenciSoyadi,OgrenciSinif,OgrenciOgretim,DevamNotu,CabaVeCalismaNotu,IsıVaktindeBitirmeNotu,AmirineKarsiDavranisNotu,IsArkadaslarinaKarsiDavranisNotu,ProjeNotu,DuzenNotu,SunumNotu,IcerikNotu,MulakatNotu,YapılanGunSayisi")] Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                db.Ogrenciler.Add(ogrenci);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ogrenci);
        }

        // GET: Ogrenci/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = db.Ogrenciler.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        // POST: Ogrenci/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OgrenciId,OgrenciAdi,OgrenciSoyadi,OgrenciNo,OgrenciSinif,OgrenciOgretim,DevamNotu,CabaVeCalismaNotu,IsiVaktindeBitirmeNotu,AmirineKarsiDavranisNotu,İsArkadaslarinaKarsiDavranisNotu,ProjeNotuDuzenNotu,SunumNotu,IcerikNotu,MulakatNotu,StajınTamamlanmaDurumu,OgrenciResim")] Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                var entity = db.Ogrenciler.Find(ogrenci.OgrenciId);
                if(entity!=null)
                {
                    entity.OgrenciAdi = ogrenci.OgrenciAdi;
                    entity.OgrenciSoyadi = ogrenci.OgrenciSoyadi;
                    entity.OgrenciNo = ogrenci.OgrenciNo;
                    entity.OgrenciSinif = ogrenci.OgrenciSinif;
                    entity.OgrenciOgretim = ogrenci.OgrenciOgretim;
                    entity.DevamNotu = ogrenci.DevamNotu;
                    entity.CabaVeCalismaNotu= ogrenci.CabaVeCalismaNotu;
                    entity.IsıVaktindeBitirmeNotu = ogrenci.IsıVaktindeBitirmeNotu;
                    entity.AmirineKarsiDavranisNotu = ogrenci.AmirineKarsiDavranisNotu;
                    entity.IsArkadaslarinaKarsiDavranisNotu = ogrenci.IsArkadaslarinaKarsiDavranisNotu;
                    entity.ProjeNotu= ogrenci.ProjeNotu;
                    entity.DuzenNotu = ogrenci.DuzenNotu;
                    entity.SunumNotu = ogrenci.SunumNotu;
                    entity.IcerikNotu = ogrenci.IcerikNotu;
                    entity.MulakatNotu = ogrenci.MulakatNotu;
                    entity.StajınTamamlanmaDurumu = ogrenci.StajınTamamlanmaDurumu;

                    db.SaveChanges();
                    TempData["Ogrenci"] = entity;

                    return RedirectToAction("Index");
                }
                
            }
            return View(ogrenci);
        }

        // GET: Ogrenci/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = db.Ogrenciler.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        // POST: Ogrenci/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ogrenci ogrenci = db.Ogrenciler.Find(id);
            db.Ogrenciler.Remove(ogrenci);
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

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
    public class StajController : Controller
    {
        private StajContext db = new StajContext();

        public string AnahtarKelime { get; private set; }

        public ActionResult List(int? id, string AnahtarKelime)
        {
            var stajlar = db.Stajlar
                 .Where(i => i.Onay == true && i.AnaSayfa==true)
                .Select(i => new StajModel()
                {
                    StajId = i.StajId,     
                    KurumAdi = i.KurumAdi,
                    YapilanSehir=i.YapilanSehir,
                    BaslamaTarihi = i.BaslamaTarihi,
                    BitisTarihi = i.BitisTarihi,
                    StajKonusu = i.StajKonusu,
                    EklenmeTarihi = i.EklenmeTarihi,
                    YapılanGünSayisi = i.YapılanGünSayisi,
                    Onay = i.Onay,
                    AnaSayfa = i.AnaSayfa,
                    CategoryId=i.CategoryId,
                    
                }).AsQueryable();




            if (string.IsNullOrEmpty("AnahtarKelime") == false)
            {
                stajlar = stajlar.Where(i => i.KurumAdi.Contains(AnahtarKelime) || i.StajKonusu.Contains(AnahtarKelime) || i.YapilanSehir.Contains(AnahtarKelime));
            }

            //if (id != null)
            //{
            //    stajlar = stajlar.Where(i => i.CategoryId == id);
            //}



            List<StajModel> x = stajlar.ToList(); // anladın mı? Anladım abi

            return View(stajlar.ToList());
        }

        

       
        // GET: Staj
        public ActionResult Index()
        {
            var stajlar = db.Stajlar.Include(s => s.Category).OrderByDescending(i => i.EklenmeTarihi);
            return View(stajlar.ToList());
        }

        // GET: Staj/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staj staj = db.Stajlar.Find(id);
            if (staj == null)
            {
                return HttpNotFound();
            }
            return View(staj);
        }

        // GET: Staj/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Kategoriler, "CategoryId", "KategoriAdi");
            return View();
        }

        // POST: Staj/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KurumAdi,YapilanSehir,BaslamaTarihi,BitisTarihi,StajKonusu,YapılanGünSayisi,CategoryId")] Staj staj)
        {
            
                
            if (ModelState.IsValid)
            {
                staj.EklenmeTarihi = DateTime.Now;
                
                db.Stajlar.Add(staj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Kategoriler, "CategoryId", "KategoriAdi", staj.CategoryId);

            var YapılanGünSayisi = db.Stajlar.Select(i => new StajModel()
            {
                YapılanGünSayisi = i.YapılanGünSayisi,

            }).AsQueryable();


            if (staj.YapılanGünSayisi < 15)
            {
                ViewBag.Uyari = "Staj yapılan gün sayısı 15'ten az olamaz!!!";
                //ModelState.AddModelError("YapılanGünSayisi", "Yapılan Gün sayısı 15'ten az olamaz!!!");
                
            }


                return View(staj);
           
        }

       
       

       

        // GET: Staj/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staj staj = db.Stajlar.Find(id);
            if (staj == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Kategoriler, "CategoryId", "KategoriAdi", staj.CategoryId);
            return View(staj);
        }

        // POST: Staj/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StajId,KurumAdi,YapilanSehir,BaslamaTarihi,Icerik,StajKonusu,BitisTarihi,YapilanGünSayisi,Onay,AnaSayfa,CategoryId")] Staj staj)
        {
            if (ModelState.IsValid)
            {
                var entity = db.Stajlar.Find(staj.StajId);
                if(entity!=null)
                {
                    entity.KurumAdi = staj.KurumAdi;
                    entity.YapilanSehir = staj.YapilanSehir;
                    entity.BaslamaTarihi = staj.BaslamaTarihi;
                    entity.Icerik = staj.Icerik;
                    entity.StajKonusu = staj.StajKonusu;
                    entity.BitisTarihi = staj.BitisTarihi;
                    entity.YapılanGünSayisi = staj.YapılanGünSayisi;
                    entity.Onay = staj.Onay;
                    entity.AnaSayfa = staj.AnaSayfa;
                    entity.CategoryId = staj.CategoryId;

                    db.SaveChanges();
                    TempData["Staj"] = entity;

                    return RedirectToAction("Index");
                }
                
            }
            ViewBag.CategoryId = new SelectList(db.Kategoriler, "CategoryId", "KategoriAdi", staj.CategoryId);
            return View(staj);
        }

        // GET: Staj/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staj staj = db.Stajlar.Find(id);
            if (staj == null)
            {
                return HttpNotFound();
            }
            return View(staj);
        }

        // POST: Staj/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Staj staj = db.Stajlar.Find(id);
            db.Stajlar.Remove(staj);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veri_Tabani_Odevi.Models;

namespace Veri_Tabani_Odevi.Controllers
{
    public class HomeController : Controller
    {
        private StajContext context = new StajContext();

        public string AnahtarKelime { get; private set; }

        // GET: Home
        public ActionResult Index()
        {
            var stajlar = context.Stajlar
                 .Where(i => i.Onay == true && i.AnaSayfa==true)
                .Select(i => new StajModel()
                 {
                     StajId = i.StajId,                    
                     KurumAdi = i.KurumAdi,
                     BaslamaTarihi = i.BaslamaTarihi,
                     StajKonusu = i.StajKonusu,
                     BitisTarihi = i.BitisTarihi,
                     EklenmeTarihi = i.EklenmeTarihi,
                     YapılanGünSayisi = i.YapılanGünSayisi,
                     Onay = i.Onay,
                     AnaSayfa = i.AnaSayfa
                 }).ToList();
            //.Where(i => i.Onay == true && i.AnaSayfa == true);

           


            return View(stajlar);
        }

        
    }
}
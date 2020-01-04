using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using Veri_Tabani_Odevi.Models;
using System;

namespace Veri_Tabani_Odevi.Controllers
{
    public class ExportPdfMulakatlarController : Controller
    {

        public static List<Mulakat> Mulakatlar = new List<Mulakat>
        {
            new Mulakat()
                {
                    OgrenciAdi="Mustafa",
                    OgrenciSoyadi="KILINÇ",
                    OgrenciNo=314033,
                    OgrenciSinif=4,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(1),
                    MulakatSaati=DateTime.Now,

                },

                new Mulakat()
                {
                    OgrenciAdi="Gürcan",
                    OgrenciSoyadi="SEBER",
                    OgrenciNo=314034,
                    OgrenciSinif=3,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(2),
                    MulakatSaati=DateTime.Now,
                },

                new Mulakat()
                {
                    OgrenciAdi="Yusuf",
                    OgrenciSoyadi="COŞKUN",
                    OgrenciNo=314035,
                    OgrenciSinif=2,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(3),
                    MulakatSaati=DateTime.Now,
                },

                new Mulakat()
                {
                    OgrenciAdi="Ömer Furkan",
                    OgrenciSoyadi="CENGİZ",
                    OgrenciNo=314036,
                    OgrenciSinif=5,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(4),
                    MulakatSaati=DateTime.Now,
                },

                new Mulakat()
                {
                    OgrenciAdi="Murat",
                    OgrenciSoyadi="GÜL",
                    OgrenciNo=314037,
                    OgrenciSinif=4,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(5),
                    MulakatSaati=DateTime.Now,
                },

                new Mulakat()
                {
                     OgrenciAdi="Serhan",
                    OgrenciSoyadi="ZEYBEK",
                    OgrenciNo=314038,
                    OgrenciSinif=3,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(6),
                    MulakatSaati=DateTime.Now,
                },

                new Mulakat()
                {
                     OgrenciAdi="Salih",
                    OgrenciSoyadi="SARIYAR",
                    OgrenciNo=314039,
                    OgrenciSinif=4,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(7),
                    MulakatSaati=DateTime.Now,
                },

                new Mulakat()
                {
                    OgrenciAdi="Taner",
                    OgrenciSoyadi="BAŞKAYA",
                    OgrenciNo=314040,
                    OgrenciSinif=5,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(8),
                    MulakatSaati=DateTime.Now,
                },

                new Mulakat()
                {
                    OgrenciAdi="Emre Can",
                    OgrenciSoyadi="GÖKTEPE",
                    OgrenciNo=314042,
                    OgrenciSinif=3,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(9),
                    MulakatSaati=DateTime.Now,
                },

                new Mulakat()
                {
                    OgrenciAdi="Barış Bahadır",
                    OgrenciSoyadi="ŞAVUR",
                    OgrenciNo=314041,
                    OgrenciSinif=2,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(10),
                    MulakatSaati=DateTime.Now,
                },

                new Mulakat()
                {
                    OgrenciAdi="Tolgahan",
                    OgrenciSoyadi="ÖZTÜRK",
                    OgrenciNo=314042,
                    OgrenciSinif=4,
                    OgrenciOgretim="2. Öğretim",
                    MulakatYeri="Bahar Hatipoğlu'nun odası",
                    MulakatTarihi=DateTime.Now.AddDays(10),
                    MulakatSaati=DateTime.Now,
                },

        };

        // GET: ExportPdfMulakatlar
        public ActionResult Index()
        {
            return View(Mulakatlar.ToList());
        }

        public ActionResult GeneratePdfRotativa()
        {
            return new Rotativa.ActionAsPdf("Index");
        }
    }
}
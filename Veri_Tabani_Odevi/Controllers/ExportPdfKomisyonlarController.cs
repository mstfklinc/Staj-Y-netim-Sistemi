using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using Veri_Tabani_Odevi.Models;

namespace Veri_Tabani_Odevi.Controllers
{
    public class ExportPdfKomisyonlarController : Controller
    {

        public static List<Komisyon> Komisyonlar = new List<Komisyon>
        {
             new Komisyon()
                {
                     OgrenciAdi="Mustafa",
                    OgrenciSoyadi="KILINÇ",
                    OgrenciNo=314033,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=1,
                },

                new Komisyon()
                {
                    OgrenciAdi="Gürcan",
                    OgrenciSoyadi="SEBER",
                    OgrenciNo=314034,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=2,
                },

                new Komisyon()
                {
                    OgrenciAdi="Yusuf",
                    OgrenciSoyadi="COŞKUN",
                    OgrenciNo=314035,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=3,
                },

                new Komisyon()
                {
                     OgrenciAdi="Ömer Furkan",
                    OgrenciSoyadi="CENGİZ",
                    OgrenciNo=314036,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=4,
                },

                new Komisyon()
                {
                    OgrenciAdi="Murat",
                    OgrenciSoyadi="GÜL",
                    OgrenciNo=314037,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=5,
                },

                new Komisyon()
                {
                     OgrenciAdi="Serhan",
                    OgrenciSoyadi="ZEYBEK",
                    OgrenciNo=314038,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=6,
                },

                new Komisyon()
                {
                      OgrenciAdi="Salih",
                    OgrenciSoyadi="SARIYAR",
                    OgrenciNo=314039,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=7,
                },

                new Komisyon()
                {
                    OgrenciAdi="Taner",
                    OgrenciSoyadi="BAŞKAYA",
                    OgrenciNo=314040,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=8,
                },

                new Komisyon()
                {
                     OgrenciAdi="Emre Can",
                    OgrenciSoyadi="GÖKTEPE",
                    OgrenciNo=314042,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=9,
                },

                new Komisyon()
                {
                     OgrenciAdi="Barış Bahadır",
                    OgrenciSoyadi="ŞAVUR",
                    OgrenciNo=314041,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=10,
                },

                new Komisyon()
                {
                     OgrenciAdi="Tolgahan",
                    OgrenciSoyadi="ÖZTÜRK",
                    OgrenciNo=314042,
                    KomisyonUye1Ad="Bahar",
                    KomisyonUye1Soyad="HATİPOĞLU",
                    KomisyonUye2Ad="Elif",
                    KomisyonUye2Soyad="BAYKAL",
                    MulakatNo=11,
                },
        };

        // GET: ExportPdfKomisyonlar
        public ActionResult Index()
        {
            return View(Komisyonlar.ToList());
        }

        public ActionResult GeneratePdfRotativa()
        {
            return new Rotativa.ActionAsPdf("Index");
        }
    }
}
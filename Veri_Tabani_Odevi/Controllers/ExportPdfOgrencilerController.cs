using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using Veri_Tabani_Odevi.Models;
namespace Veri_Tabani_Odevi.Controllers
{
    public class ExportPdfOgrencilerController : Controller
    {

        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci()
                {
                    OgrenciAdi="Mustafa",
                    OgrenciSoyadi="KILINÇ",
                    OgrenciNo=314033,
                    OgrenciSinif=4,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=5,
                    CabaVeCalismaNotu=5,
                    IsıVaktindeBitirmeNotu=5,
                    AmirineKarsiDavranisNotu=5,
                    IsArkadaslarinaKarsiDavranisNotu=5, // anladım bunu hesaplayıp nerede kullanaaksın gösteriyorum abi
                    ProjeNotu=100,
                    DuzenNotu=100,
                    SunumNotu=100,
                    IcerikNotu=100,
                    MulakatNotu=100,
                    YapılanGunSayisi=30,

                },

                new Ogrenci()
                {
                    OgrenciAdi="Gürcan",//göster kardeşim
                    OgrenciSoyadi="SEBER",
                    OgrenciNo=314034,
                    OgrenciSinif=3,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=5,
                    CabaVeCalismaNotu=4,
                    IsıVaktindeBitirmeNotu=3,
                    AmirineKarsiDavranisNotu=5,
                    IsArkadaslarinaKarsiDavranisNotu=5,
                    ProjeNotu=90,
                    DuzenNotu=70,
                    SunumNotu=90,
                    IcerikNotu=90,
                    MulakatNotu=90,
                    YapılanGunSayisi=30,

                },

                new Ogrenci()
                {
                    OgrenciAdi="Yusuf",
                    OgrenciSoyadi="COŞKUN",
                    OgrenciNo=314035,
                    OgrenciSinif=2,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=5,
                    CabaVeCalismaNotu=5,
                    IsıVaktindeBitirmeNotu=3,
                    AmirineKarsiDavranisNotu=5,
                    IsArkadaslarinaKarsiDavranisNotu=5,
                    ProjeNotu=70,
                    DuzenNotu=80,
                    SunumNotu=60,
                    IcerikNotu=90,
                    MulakatNotu=70,
                    YapılanGunSayisi=30,
                },

                new Ogrenci()
                {
                    OgrenciAdi="Ömer Furkan",
                    OgrenciSoyadi="CENGİZ",
                    OgrenciNo=314036,
                    OgrenciSinif=5,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=5,
                    CabaVeCalismaNotu=3,
                    IsıVaktindeBitirmeNotu=4,
                    AmirineKarsiDavranisNotu=5,
                    IsArkadaslarinaKarsiDavranisNotu=5,
                    ProjeNotu=70,
                    DuzenNotu=80,
                    SunumNotu=90,
                    IcerikNotu=70,
                    MulakatNotu=90,
                    YapılanGunSayisi=30,
                },

                new Ogrenci()
                {
                    OgrenciAdi="Murat",
                    OgrenciSoyadi="GÜL",
                    OgrenciNo=314037,
                    OgrenciSinif=4,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=4,
                    CabaVeCalismaNotu=3,
                    IsıVaktindeBitirmeNotu=4,
                    AmirineKarsiDavranisNotu=5,
                    IsArkadaslarinaKarsiDavranisNotu=5,
                    ProjeNotu=70,
                    DuzenNotu=90,
                    SunumNotu=80,
                    IcerikNotu=90,
                    MulakatNotu=100,
                    YapılanGunSayisi=30,
                },

                new Ogrenci()
                {
                    OgrenciAdi="Serhan",
                    OgrenciSoyadi="ZEYBEK",
                    OgrenciNo=314038,
                    OgrenciSinif=3,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=5,
                    CabaVeCalismaNotu=4,
                    IsıVaktindeBitirmeNotu=3,
                    AmirineKarsiDavranisNotu=4,
                    IsArkadaslarinaKarsiDavranisNotu=3,
                    ProjeNotu=80,
                    DuzenNotu=90,
                    SunumNotu=80,
                    IcerikNotu=90,
                    MulakatNotu=100,
                    YapılanGunSayisi=30,
                },

                new Ogrenci()
                {
                    OgrenciAdi="Salih",
                    OgrenciSoyadi="SARIYAR",
                    OgrenciNo=314039,
                    OgrenciSinif=4,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=5,
                    CabaVeCalismaNotu=3,
                    IsıVaktindeBitirmeNotu=4,
                    AmirineKarsiDavranisNotu=5,
                    IsArkadaslarinaKarsiDavranisNotu=5,
                    ProjeNotu=80,
                    DuzenNotu=90,
                    SunumNotu=100,
                    IcerikNotu=90,
                    MulakatNotu=80,
                    YapılanGunSayisi=30,
                },

                new Ogrenci()
                {
                    OgrenciAdi="Taner",
                    OgrenciSoyadi="BAŞKAYA",
                    OgrenciNo=314040,
                    OgrenciSinif=5,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=5,
                    CabaVeCalismaNotu=4,
                    IsıVaktindeBitirmeNotu=5,
                    AmirineKarsiDavranisNotu=5,
                    IsArkadaslarinaKarsiDavranisNotu=5,
                    ProjeNotu=80,
                    DuzenNotu=90,
                    SunumNotu=80,
                    IcerikNotu=90,
                    MulakatNotu=70,
                    YapılanGunSayisi=30,
                },

                new Ogrenci()
                {
                    OgrenciAdi="Barış Bahadır",
                    OgrenciSoyadi="ŞAVUR",
                    OgrenciNo=314041,
                    OgrenciSinif=3,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=5,
                    CabaVeCalismaNotu=4,
                    IsıVaktindeBitirmeNotu=5,
                    AmirineKarsiDavranisNotu=3,
                    IsArkadaslarinaKarsiDavranisNotu=5,
                    ProjeNotu=80,
                    DuzenNotu=80,
                    SunumNotu=80,
                    IcerikNotu=100,
                    MulakatNotu=70,
                    YapılanGunSayisi=30,
                },

                new Ogrenci()
                {
                    OgrenciAdi="Emre Can",
                    OgrenciSoyadi="GÖKTEPE",
                    OgrenciNo=314042,
                    OgrenciSinif=2,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=4,
                    CabaVeCalismaNotu=5,
                    IsıVaktindeBitirmeNotu=5,
                    AmirineKarsiDavranisNotu=3,
                    IsArkadaslarinaKarsiDavranisNotu=5,
                    ProjeNotu=100,
                    DuzenNotu=80,
                    SunumNotu=90,
                    IcerikNotu=100,
                    MulakatNotu=70,
                    YapılanGunSayisi=30,
                },

                new Ogrenci()
                {
                    OgrenciAdi="Tolgahan",
                    OgrenciSoyadi="ÖZTÜRK",
                    OgrenciNo=314043,
                    OgrenciSinif=4,
                    OgrenciOgretim="2. Öğretim",
                    OgrenciResim="1.jpg",
                    DevamNotu=5,
                    CabaVeCalismaNotu=4,
                    IsıVaktindeBitirmeNotu=3,
                    AmirineKarsiDavranisNotu=4,
                    IsArkadaslarinaKarsiDavranisNotu=5,
                    ProjeNotu=80,
                    DuzenNotu=90,
                    SunumNotu=70,
                    IcerikNotu=90,
                    MulakatNotu=100,
                    YapılanGunSayisi=60,
                },
        };

        // GET: ExportPdfOgrenciler
        public ActionResult Index()
        {
            return View(Ogrenciler.ToList());
        }

        public ActionResult GeneratePdfRotativa()
        {
            return new Rotativa.ActionAsPdf("Index");
        }
    }
}
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using Veri_Tabani_Odevi.Models;
using System;

namespace Veri_Tabani_Odevi.Controllers
{
    public class ExportPdfStajlarController : Controller
    {

        public static List<Staj> stajlar = new List<Staj>
        {
            new Staj()
                {

                    KurumAdi="SOFTTECH",
                    YapilanSehir="İSTANBUL",
                    StajKonusu="Android Programlama",
                    Icerik="Android programlamaya dair herşey",
                    StajResim="1.jpg",
                    YapılanGünSayisi=30,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=1
                },
                new Staj()
                {

                    KurumAdi="SOFTTECH",
                    YapilanSehir="İSTANBUL",
                    StajKonusu="iOS Programlama",
                    Icerik="iOS programlamaya dair herşey",
                    StajResim="2.jpg",
                    YapılanGünSayisi=30,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=2
                },
                new Staj()
                {

                    KurumAdi="MIP",
                    StajKonusu="Bilgisayar Ağları",
                    YapilanSehir="MERSİN",
                    Icerik="Bilgisayar ağlarına dair herşey",
                    StajResim="3.jpg",
                    YapılanGünSayisi=25,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=3
                },

                new Staj()
                {

                    KurumAdi="HEPSİBURADA.COM",
                    StajKonusu="java Programlama",
                    YapilanSehir="İSTANBUL",
                    Icerik="Java programlamaya dair herşey",
                    StajResim="4.jpg",
                    YapılanGünSayisi=30,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=4
                },

                new Staj()
                {

                    KurumAdi="TOSHIBA",
                    StajKonusu="Gömülü Sistemler",
                    YapilanSehir="İSTANBUL",
                    Icerik="Android programlamaya dair herşey",
                    StajResim="5.jpg",
                    YapılanGünSayisi=30,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=5
                },

                new Staj()
                {

                    KurumAdi="TURKCELL",
                    StajKonusu="Yazılım Test",
                    YapilanSehir="İSTANBUL",
                    Icerik="Yazılım testine dair herşey",
                    StajResim="6.jpg",
                    YapılanGünSayisi=30,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=6
                },

                new Staj()
                {

                    KurumAdi="VODAFONE",
                     YapilanSehir="İSTANBUL",
                    StajKonusu="Veri Tabanı Yönetim Sistemleri",
                    Icerik="Veri Tabanı Yönetim Sistemlerine dair herşey",
                    StajResim="7.jpg",
                    YapılanGünSayisi=30,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=7
                },

                new Staj()
                {

                    KurumAdi="TÜBİTAK",
                    YapilanSehir="ANKARA",
                    StajKonusu="Yapay Zeka",
                    Icerik="Yapay Zekaya dair herşey",
                    StajResim="8.jpg",
                    YapılanGünSayisi=30,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=8
                },

                new Staj()
                {

                    KurumAdi="TAI",
                    YapilanSehir="ANKARA",
                    StajKonusu="Görüntü İşleme",
                    Icerik="Görüntü işlemeye dair herşey",
                    StajResim="9.jpg",
                    YapılanGünSayisi=30,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=9
                },

                new Staj()
                {

                    KurumAdi="ASELSAN",
                    YapilanSehir="ANKARA",
                    StajKonusu="Yapay Sinir Ağları",
                    Icerik="Yapay Sinir Ağlarına dair herşey",
                    StajResim="10.jpg",
                    YapılanGünSayisi=25,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=10
                },

                 new Staj()
                {

                    KurumAdi="HAVELSAN",
                    YapilanSehir="ANKARA",
                    StajKonusu="AR-GE",
                    Icerik="Yapay Sinir Ağlarına dair herşey",
                    StajResim="11.jpg",
                    YapılanGünSayisi=25,
                    BaslamaTarihi=DateTime.Now.AddDays(-40),
                    BitisTarihi=DateTime.Now.AddDays(-10),
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Onay=true,
                    AnaSayfa=true,
                    CategoryId=11
                },
        };

        // GET: ExportPdfStajlar
        public ActionResult Index()
        {
            return View(stajlar.ToList());
        }

        public ActionResult GeneratePdfRotativa()
        {
            return new Rotativa.ActionAsPdf("Index");
        }

    }
}
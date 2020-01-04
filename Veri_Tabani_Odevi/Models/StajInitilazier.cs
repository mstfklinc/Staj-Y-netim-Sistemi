using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace Veri_Tabani_Odevi.Models
{
    //böyle garip bir şey görmedim amg :D
    // olayı anlmamışsın kardeşim, DbContext => entity frameworkün interfacesi, her naneyi yapan alt bu, sen gitmiş db context diye class tanımlamşıssın, ondan aklı gidiyor aletin. bende diyorum bu kadar basit bişe nasıl olmaz :D
    public class StajInitilazier : CreateDatabaseIfNotExists<StajContext>
    {
        protected override void Seed(StajContext context) // Seed metodu veritabanına test verileri eklememizi sağlar.
        {
            List<Category> Kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="Android Programlama"},
                new Category(){KategoriAdi="iOS Programlama"},
                new Category(){KategoriAdi="Bilgisayar Ağları"},
                new Category(){KategoriAdi="Java Programlama"},
                new Category(){KategoriAdi="Gömülü Sistemler"},
                new Category(){KategoriAdi="Yazılım Test"},
                new Category(){KategoriAdi="Veri Tabanı Yönetim Sistemleri"},
                new Category(){KategoriAdi="Yapay Zeka"},
                new Category(){KategoriAdi="Görüntü İşleme" }, 
                new Category(){KategoriAdi="Yapay Sinir Ağları"},
                new Category(){KategoriAdi="AR-GE"},
                      
            };

            foreach (var item in Kategoriler)
            {
                context.Kategoriler.Add(item);
                
            }
            context.SaveChanges();

            List<Staj> stajlar = new List<Staj>()
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
            foreach (var item in stajlar)
            {
                context.Stajlar.Add(item);
            }
            context.SaveChanges();

            List<Ogrenci> ogrenciler = new List<Ogrenci>()
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

            foreach (var item in ogrenciler)
            {
                context.Ogrenciler.Add(item);
            }
            context.SaveChanges();

            List<Mulakat> mulakatlar = new List<Mulakat>()
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

            foreach (var item in mulakatlar)
            {
                context.Mulakatlar.Add(item);
            }
            context.SaveChanges();


            List<Komisyon> komisyonlar = new List<Komisyon>()
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

            foreach (var item in komisyonlar)
            {
                context.Komisyonlar.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);

            //5 ARALIK DÜNYA MÜHENDİSLER GÜNÜ KUTLU OLSUN...
        }
    }
}
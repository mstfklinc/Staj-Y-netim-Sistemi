using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veri_Tabani_Odevi.Models
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public int OgrenciNo { get; set; }
        public string OgrenciOgretim { get; set; }
        public int OgrenciSinif { get; set; }
        public string OgrenciResim { get; set; }
        public int DevamNotu { get; set; }
        public int CabaVeCalismaNotu { get; set; }
        public int IsıVaktindeBitirmeNotu { get; set; }
        public int AmirineKarsiDavranisNotu { get; set; }
        public int IsArkadaslarinaKarsiDavranisNotu { get; set; }
        public int ProjeNotu { get; set; }
        public int DuzenNotu { get; set; }
        public int SunumNotu { get; set; }
        public int IcerikNotu { get; set; }
        public int MulakatNotu { get; set; }
        public int HesaplananNotKatsayisi { get; set; }
        public int KabulEdilenGunSayisi { get; set; }
        public int KalanGünSayisi { get; set; }
        public bool StajınTamamlanmaDurumu { get; set; }


        public List<OgrenciYaparStaj> Stajlar { get; set; }
        public List<OgrenciGirerMulakat> Mülakatlar { get; set; }

        public Staj Staj { get; set; }
        public int YapılanGunSayisi { get; set; }
        

    }
}
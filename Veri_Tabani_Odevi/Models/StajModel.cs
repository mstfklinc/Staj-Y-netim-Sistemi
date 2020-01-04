using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veri_Tabani_Odevi.Models
{
    public class StajModel
    {
        public int StajId { get; set; }
        public string KurumAdi { get; set; }
        
        public DateTime BaslamaTarihi { get; set; }
        public string StajResim { get; set; }     
        public string Icerik { get; set; }   
        public string StajKonusu { get; set; }
        public string YapilanSehir { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public int YapılanGünSayisi { get; set; }
        public bool Onay { get; set; }
        public bool AnaSayfa { get; set; }
        public int CategoryId { get; set; }

        public Ogrenci Ogrenci { get; set; }
        
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public int OgrenciNo { get; set; }
        public int OgrenciSinif { get; set; }

        //public List<Staj> Stajlar { get; set; }
        //public string YapilanSehir { get; set; }
    }
}
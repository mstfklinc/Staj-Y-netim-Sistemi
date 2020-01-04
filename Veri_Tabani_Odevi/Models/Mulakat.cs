using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veri_Tabani_Odevi.Models
{
    public class Mulakat
    {
        [Key]
        public int MulakatId { get; set; }
        public DateTime MulakatTarihi { get; set; }
        public DateTime MulakatSaati { get; set; }
        public string MulakatYeri { get; set; }

        

        public List<OgrenciGirerMulakat> Mülakat { get; set; }
        public List<Ogrenci> Ogrenci { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public int OgrenciNo { get; set; }
        public int OgrenciSinif { get; set; }
        public string OgrenciOgretim { get; set; }

        //public Staj Staj { get; set; }
        //public int StajId { get; set; }

    }
}
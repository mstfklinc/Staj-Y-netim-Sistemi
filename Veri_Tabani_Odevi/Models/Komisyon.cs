using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veri_Tabani_Odevi.Models
{
    public class Komisyon
    {
        [Key]
        public int KomisyonId { get; set; }
        public string KomisyonUye1Ad { get; set; }
        public string KomisyonUye1Soyad { get; set; }
        public string KomisyonUye2Ad { get; set; }
        public string KomisyonUye2Soyad { get; set; }


        public int MulakatNo { get; set; }
        public Mulakat Mulakat { get; set; }

        public List<Ogrenci> Ogrenci { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public int OgrenciNo { get; set; }

    }
}
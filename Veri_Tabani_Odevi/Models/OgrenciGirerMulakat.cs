using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veri_Tabani_Odevi.Models
{
    public class OgrenciGirerMulakat
    {
        [Key]
        public int OgrenciGirerMülakatId { get; set; }


        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int MulakatId { get; set; }
        public Mulakat Mulakat { get; set; }
    }
}
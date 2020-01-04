using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veri_Tabani_Odevi.Models
{
    //kardeşim öncelikle _ bu karakteri kullanmak önerilmiyor camelCase yazman lazım.
    public class OgrenciYaparStaj
    {
        [Key]
        public int OgrenciYaparStaj_Id { get; set; }

        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int StajId { get; set; }
        public Staj Staj { get; set; }

    }
}
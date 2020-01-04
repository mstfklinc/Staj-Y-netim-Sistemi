using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veri_Tabani_Odevi.Models
{
    public class CategoryModel
    {
        [Key]
        public int  CategoryModelId { get; set; }
        public string KategoriAdi { get; set; }
        public int StajSayisi { get; set; }

        

    }
}
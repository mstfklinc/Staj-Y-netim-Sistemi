using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veri_Tabani_Odevi.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } //Primary key
        public string KategoriAdi { get; set; }

        public List<Staj> Stajlar { get; set; } //Foreign key
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Veri_Tabani_Odevi.Models
{
    public class StajContext : DbContext //VeritabanıContext sınıfı bizim için veri tabanını yöneten sınıftır.Yani bu sınıf veri tabanının kendisidir.
    {
        public StajContext():base("StajDb")
        {
            Database.SetInitializer(new StajInitilazier());
        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Staj> Stajlar { get; set; }
        public DbSet<Mulakat> Mulakatlar { get; set; }
        public DbSet<Komisyon> Komisyonlar { get; set; }
        public DbSet<OgrenciYaparStaj> OgrenciYaparStaj{ get; set; }
        public DbSet<OgrenciGirerMulakat> OgrenciGirerMulakat { get; set; }
        public DbSet<Category> Kategoriler { get; set; }

        //public System.Data.Entity.DbSet<Veri_Tabani_Odevi.Models.CategoryModel> CategoryModels { get; set; }
    }
}
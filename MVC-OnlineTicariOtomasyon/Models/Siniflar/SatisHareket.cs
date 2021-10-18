using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_OnlineTicariOtomasyon.Models.Siniflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisId { get; set; }
        //ürün
        //cari
        //personel
        public DateTime SatisTarih { get; set; }
        public int SatisAdet { get; set; }
        public decimal SatisFiyat { get; set; }
        public decimal SatisToplamTutar { get; set; }
        public Urun Urun { get; set; }
        public Cariler Cariler { get; set; }
        public Personel Personel { get; set; }
    }
}
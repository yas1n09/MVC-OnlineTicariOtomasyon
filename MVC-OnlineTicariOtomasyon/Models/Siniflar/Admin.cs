using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_OnlineTicariOtomasyon.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string AdminKullaniciAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string AdminSifre { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]

        public string AdminYetki { get; set; }
    }
}
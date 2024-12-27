using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Kategori //Kategori isminde bir veri tablom olacak
    {
        [Key]
        public int KategoriID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }

        public ICollection<Urun> Uruns { get; set; }
        // urunlerimizi tutacağımız ilişkili tablola c^kod bloğu
        //Her bir kategoride birden fazla ürün yer alabilir.
    }


}
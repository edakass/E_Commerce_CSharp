using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace My_Project.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }


        
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }
        //bire çok ilişki,her ürünün bir kategorisi olacak,bir kategori birden fazla üründe bulunucak
        //ICollection nedir bak,interface dir

        //her bir kategorimde birden fazla ürün yer alabilir
        public ICollection<Urun> Uruns { get; set; }
            //vt de uruns olarak oluşturulacak

        
      
        
    }
}
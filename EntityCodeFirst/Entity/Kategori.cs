using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Kategori //public yap
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public ICollection<Urunler>Urunlers { get; set; }
        //1 kategori birden fazla ürünle ilişkilendirilebileceği için COLLECTION KULLANDIM
    }
}

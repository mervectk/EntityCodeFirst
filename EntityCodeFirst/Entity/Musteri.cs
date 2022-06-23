using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
   public class Musteri //public yaptım
    {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        //public string MusteriUnvani { get; set; }//SÜTUN SİLECEĞİM!!

        public string MusteriSehri { get; set; } //ekledim
    }
}

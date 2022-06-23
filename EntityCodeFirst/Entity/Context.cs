using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityCodeFirst.Entity


{
    //TABLO OLUŞTURMA
    class Context:DbContext //dll ihtiyaç var bunun için entityframework ekledik 
    {
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; } 
        
    }
}

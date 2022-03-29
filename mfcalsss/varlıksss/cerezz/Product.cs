using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.ana;

namespace varlıksss.cerezz
{
    public class Product:IEntities
    {
        public int ProductId { get; set; }
        public int KategoriId { get; set; }
        public string Productadı { get; set; }
        public short Stok { get; set; }
        public decimal ProductFiyat { get; set; }
       






    }
}

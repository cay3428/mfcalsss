using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.ana;

namespace varlıksss.cerezz
{
    public class Product:IEntities
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short UnitinStock { get; set; }
        public decimal UnitPrice { get; set; }
       






    }
}

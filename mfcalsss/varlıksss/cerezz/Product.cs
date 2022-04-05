using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
 

namespace varlıksss.cerezz
{
    public class Product:IEntities
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
      
    
       public string NationalIdentity { get; set; }



        
        //[Required]
        //[MinLength(2)]

    }
}

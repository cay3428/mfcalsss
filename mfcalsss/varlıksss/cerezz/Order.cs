﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.cerezz
{
   public  class Order:IEntities
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}

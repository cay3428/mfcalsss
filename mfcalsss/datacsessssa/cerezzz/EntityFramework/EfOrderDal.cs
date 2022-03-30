using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccsess.EntityFramework;
using DataAccsess.ana;
using Entities.cerezz;

namespace DataAccsess.cerezzz.EntityFramework
{
  public   class EfOrderDal:EfEntityResporityBase<Order,NorthwindContext>, IOrderDal
    {
    }
}

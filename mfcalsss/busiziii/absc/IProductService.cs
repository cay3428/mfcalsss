using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;

namespace busiziii.absc
{
public  interface IProductService
    {


        List<Product> GetAll();
        List<Product> GetAllByCategor(int id);
        List<Product> GetByUnitPrice(decimal min,decimal max);


    }
}

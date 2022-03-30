﻿using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;

namespace busiziii.absc
{
public  interface IProductService
    {


        List<Product> GetAll();
        List<Product> GetAllByCategory(int id);
        List<Product> GetByUnitPrice(decimal min,decimal max);

        List<ProductDetailDto> GetProductDetails();


    }
}

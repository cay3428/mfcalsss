using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;
using DataAccsess.ana;
using Core.DataAccsess;
using Entities.DTOs;

namespace datacsessssa.ana
{
    public interface IProductDal : IEntityRespository<Product>
    {
        List<ProductDetailDto> GetProductDetails();



    }
}

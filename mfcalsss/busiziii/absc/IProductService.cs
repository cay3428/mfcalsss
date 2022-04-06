using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;

namespace busiziii.absc
{
public  interface IProductService
    {
        //void Add(Product product);

        //List<Product> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
      IDataResult < List<Product>> GetByUnitPrice(decimal min,decimal max);

       IDataResult <List<ProductDetailDto>> GetProductDetails();

     IDataResult   <Product> GetById(int procudtId);
      
        IResult Add(Product product);
         
        IDataResult<List<Product>> GetAll();

        IResult Update(Product product);





    }
}

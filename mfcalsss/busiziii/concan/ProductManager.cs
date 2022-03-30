using busiziii.absc;
using datacsessssa.ana;
using datacsessssa.cerezzz.Hafıza;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;

namespace busiziii.concan
{
    public class ProductManager : IProductService
    {
       IProductDal  _productDal;

        public ProductManager (IProductDal productDal)
        {


            _productDal = productDal;

        }




        public List<Product> GetAll()
        {

            return _productDal.GetAll();

             

        }

        public List<Product> GetAllByCategory(int id)
        {

            return _productDal.GetAll(p => p.CategoryID == id );
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {

            return _productDal.GetProductDetails();

        }
    }
}


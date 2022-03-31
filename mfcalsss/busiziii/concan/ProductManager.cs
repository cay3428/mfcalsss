﻿using busiziii.absc;
using busiziii.contan;
using Core.Utilities.Results;
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

        //public void Add(Product product)
        //{
        //    _productDal.Add(product);
        //}

         

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorResult();
            }


            return  new SuccesDataResult  <List<Product>> ( _productDal.GetAll(),true ,"listelendi");

             

        }

        public IDataResult < List<Product>> GetAllByCategory(int id)
        {

            return  _productDal.GetAll(p => p.CategoryID == id );
        }

        public IDataResult < Product> GetById(int procudtId)
        {
            return _productDal.Get(p => p.ProductID == procudtId);
        }

        public IDataResult< List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }

        public IDataResult< List<ProductDetailDto>> GetProductDetails()
        {

            return _productDal.GetProductDetails();

        }

    public    IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {

                return new ErrorResult(Messages.ProductNameInvalid);

            }
            _productDal.Add(product);


            return new SuccessResult(Messages.ProductAdded);

            _productDal.Add(product);
            //Result result = new Result();
            
            
            
            return new SuccessResult("eklendş");
        }
    }
}


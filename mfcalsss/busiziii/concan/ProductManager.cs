using busiziii.absc;
using busiziii.CCS;
using busiziii.contan;
using busiziii.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using datacsessssa.ana;
using datacsessssa.cerezzz.Hafıza;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;

namespace busiziii.concan
{
    public class ProductManager : IProductService
    {
       IProductDal  _productDal;
        ILogger _logger;



        public ProductManager (IProductDal productDal)
        {


            _productDal = productDal;

        }

        //public void Add(Product product)
        //{
        //    _productDal.Add(product);
        //}
         
         

        public IDataResult<List<Product>> GetAll() { 
        //{ 
        //    if (DateTime.Now.Hour==22)
        //    {
        //        return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
        //    }


            return  new SuccesDataResult<List<Product>> ( _productDal.GetAll(),Messages.ProductsListed);

             

        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }


            return new SuccesDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryID == id));
        }

        public IDataResult < Product> GetById(int procudtId)
        {
             return new SuccesDataResult<Product> (_productDal.Get(p => p.ProductID == procudtId));
            
        }

        public IDataResult< List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max));
        }

        public IDataResult < List<ProductDetailDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }

            return   new SuccesDataResult<List<ProductDetailDto>> ( _productDal.GetProductDetails());

        }

        //[LogAspect]-->AOP
        //    [Validate]
        //    [RemoveCache]
        //    [Transcation]
        //    [Performance]
        [ValidationAspect(typeof(Product ))]

    public    IResult Add(Product product)
        {
            _logger.Log();
            try
            {
                _productDal.Add(product);


                return new SuccessResult(Messages.ProductAdded);

            }
            catch (Exception exception)
            {

                _logger.Log();
            }

            return new ErrorResult(); 

            //ValidationTool.Validate(new ProductValidator(), product);
            

          
     
            
            

        }

       
    }
}


////if (product.UnitPrice <= 0)

////{


////    return new ErrorResult(Messages.UnitPriceInvalid);




////}





////if (product.ProductName.Length < 2)
////{

////    return new ErrorResult(Messages.ProductNameInvalid);

////}
///         //   return new SuccessResult("eklendş");
///               // _productDal.Add(product);
//Result result = new Result();

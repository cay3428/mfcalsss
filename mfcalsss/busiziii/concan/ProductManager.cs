using busiziii.absc;
using busiziii.CCS;
using busiziii.contan;
using busiziii.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccsess.ana;
using datacsessssa.ana;
using datacsessssa.cerezzz.Hafıza;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using varlıksss.cerezz;
using static Core.Utilities.Business.BusinnesRules;

namespace busiziii.concan
{
    public class ProductManager : IProductService
    {
        ICategoryService _categoryService;
        IProductDal  _productDal;
         ICategoryDal _categoryDal;


        public ProductManager(IProductDal productDal,ICategoryService categoryService,ICategoryDal categoryDal)
        {
            _categoryService = categoryService;
           _categoryDal= categoryDal;

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
        //[SecuredOperation("product.admin,editor,")]
        [ValidationAspect(typeof(Product ))]


    public    IResult Add(Product product)
        {
      IResult result =     BusinessRules.Run(CheckIfProductNameExistst(product.ProductName),
            CheckIfProductCountOFCategoryCorrect (product.CategoryID));
             
            if(result != null)
            {
                return result;
            }


            if (CheckIfProductCountOFCategoryCorrect(product.CategoryID).Success)
            {
                if (CheckIfProductNameExistst(product.ProductName).Success)
                {

                    _productDal.Add(product);

                    return new SuccessResult(Messages.ProductAdded);

                }



            }


            return new ErrorResult();
            //kategori sınırı 15



            //_logger.Log();
            //try
            //{


            //    return new SuccessResult(Messages.ProductAdded);

            //}
            //catch (Exception exception)
            //{

            //    _logger.Log();
            //}


            //ValidationTool.Validate(new ProductValidator(), product);

        }

        [ValidationAspect (typeof (ProductValidator))]

        public IResult Update(Product product)
        {

            var result = _productDal.GetAll(p => p.CategoryID == product.CategoryID).Count;

            if (result >= 10)
            {

                return new ErrorResult(Messages.ProductCountofCategoryError);

            }

            throw new    NotImplementedException();


        }

        private IResult CheckIfProductCountOFCategoryCorrect(int categoryID)
        {
            //Select count(*) from product where category ıd=1
            var result = _productDal.GetAll(p => p.CategoryID == categoryID).Count;

            if (result >= 15)
            {

                return new ErrorResult(Messages.ProductCountofCategoryError);

            }
            return new SuccessResult();
                    
        }

        private IResult CheckIfProductNameExistst(string productName)
        {
            //Select count(*) from product where category ıd=1
            var result = _productDal.GetAll(p => p.ProductName == productName).Any();

            if (result )
            {

                return new ErrorResult(Messages.ProductNameAlreadyExists);

            }
            return new SuccessResult();

        }

        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count>15)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);
            }
            return new SuccessResult();
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

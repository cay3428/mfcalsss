﻿using busiziii.absc;
using Core.Utilities.Results;
using DataAccsess.ana;
using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;

namespace busiziii.concan
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        
      
     public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public IDataResult <List<Category>> GetAll()
        {
            return new SuccesDataResult<List<Category >>(_categoryDal.GetAll());
        }

        public IDataResult <Category> GetById(int categoryId)
        {

            return new SuccesDataResult <Category >( _categoryDal.Get(c => c.CategoryID == categoryId));
 
        }


     
    }
}

 
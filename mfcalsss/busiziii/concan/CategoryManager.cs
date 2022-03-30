using busiziii.absc;
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


        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {

            return  _categoryDal.Get(c => c.CategoryID == categoryId);
 
        }

        List<Category> ICategoryService.GetById(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}

 
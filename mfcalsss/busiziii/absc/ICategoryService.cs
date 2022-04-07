using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;

namespace busiziii.absc
{
  public  interface ICategoryService
    {
      IDataResult < List<Category>> GetAll();
      IDataResult  <Category> GetById(int categoryId);

         
    }














}

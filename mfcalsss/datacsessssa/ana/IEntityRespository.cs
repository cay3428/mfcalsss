using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;

namespace DataAccsess.ana
{
 public    interface IEntityRespository <T>
    {




        List<T> GetAll(Expression<Func<T, bool>> filter = null );
        T Get();
        void Ekle(T entity);
        void güncelle(T entity);
        void yoket(T entity);

        List<T> Getallbycategory(int categoryId);










    }
}

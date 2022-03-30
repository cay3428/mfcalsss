using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccsess





//IEntity :Ientity olabilir veya Ientity implemente eden var nesne olabilir








{
    public    interface IEntityRespository <T> where T:class,IEntities,new()
    { 




        List<T> GetAll(Expression<Func<T, bool>> filter = null );
        T Get(Expression<Func<T,bool>>filter); 
        void Ekle(T entity);
        void güncelle(T entity);
        void yoket(T entity);

        //List<T> Getallbycategory(int categoryId);










    }
}

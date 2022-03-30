using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
namespace Core.DataAccsess.EntityFramework
{
    public class EfEntityResporityBase<TEntity, TContext> : IEntityRespository<TEntity>
        where TEntity : class, IEntities, new()
        where TContext : DbContext, new()
    {
        public void Ekle(TEntity entity)
        {
            using (TContext context=new TContext())
            {
                var addedEntity = context.Entry(entity);
        addedEntity.State = EntityState.Added;
                context.SaveChanges();



            }
}

public TEntity Get(Expression<Func<TEntity, bool>> filter)
{

    using (TContext context = new TContext())
    {
        return context.Set<TEntity>().SingleOrDefault(filter);



    }




}


        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
{
    using (TContext context = new TContext())
    {
        return filter == null
            ? context.Set<TEntity>().ToList()
            : context.Set<TEntity>().Where(filter).ToList();




    }


}

public List<TEntity> Getallbycategory(int categoryId)
{
    throw new NotImplementedException();
}

public void güncelle(TEntity entity)
{
    using (TContext context = new TContext())
    {
        var updatedEntity = context.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        context.SaveChanges();

    }




}

public void yoket(TEntity entity)
{
    using (TContext context = new TContext())
    {
        var deletedEntity = context.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        context.SaveChanges();

    }







} 























    }
}








 

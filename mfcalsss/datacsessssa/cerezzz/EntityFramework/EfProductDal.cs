using datacsessssa.ana;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using varlıksss.cerezz;

namespace DataAccsess.cerezzz.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Ekle(Product entity)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();



            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);



            }




        }

        public List<Product> GetAll()
        {

            return new List<Product> { new Product { Productadı = "listett" }, new Product { Productadı = "su" } };

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
                                                                                                                         



            }


        }

        public List<Product> Getallbycategory(int categoryId)
        {
            throw new NotImplementedException();
        } 

        public void güncelle(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }




        }

        public void yoket(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }







        }
    }
}

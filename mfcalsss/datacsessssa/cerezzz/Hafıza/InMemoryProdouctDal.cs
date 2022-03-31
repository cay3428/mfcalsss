using datacsessssa.ana;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using varlıksss.cerezz;

namespace datacsessssa.cerezzz.Hafıza
{
    public class InMemoryProdouctDal : IProductDal

    {
        List<Product> _products;
        public InMemoryProdouctDal()
        {
            _products = new List<Product> {
              new Product { CategoryID=1,ProductID=1,ProductName="tün",UnitsInStock=0,UnitPrice=9900},
         



             };
 }

        public void Ekle(Product products)
        {
            _products.Add(products);
        }

        public List<Product> GetAll()

        {
            return _products;

        }

        public List<Product> Getallbycategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void güncelle(Product product)
        {
            Product productgüncelle = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productgüncelle.CategoryID = product.CategoryID;
            productgüncelle.ProductName = product.ProductName;
            productgüncelle.UnitPrice = product.UnitPrice;
            productgüncelle.UnitsInStock = product.UnitsInStock;

               







        }

        public void yoket(Product product)
        {
            Product productyoket = null;
            foreach (var p in _products )
            {
                if (product.ProductID==p.ProductID)
                {

                    productyoket = p;

                }

                
            }
            productyoket = _products.SingleOrDefault(p=>p.ProductID==product.ProductID);


            _products.Remove(productyoket);
     
        }
         public List<Product> getallbycategory(int categoryId)
        {

          return  _products.Where(p => p.CategoryID ==categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }
    }



        }



 
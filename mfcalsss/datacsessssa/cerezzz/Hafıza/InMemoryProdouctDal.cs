using datacsessssa.ana;
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
              new Product {Productadı="thata",ProductFiyat=15,ProductId=1,KategoriId=6,Stok=80 },
              new Product {Productadı="dağkıyısı",ProductFiyat=15,ProductId=1,KategoriId=6,Stok=80 },
             new Product {Productadı="toprakkığı",ProductFiyat=15,ProductId=1,KategoriId=6,Stok=80 },
              new Product {Productadı="alyaz",ProductFiyat=15,ProductId=1,KategoriId=6,Stok=80 },
               new Product {Productadı="tünekalan",ProductFiyat=15,ProductId=1,KategoriId=6,Stok=80 },
                 new Product {Productadı="hüküm",ProductFiyat=15,ProductId=1,KategoriId=6,Stok=80 }




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
            Product productgüncelle = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productgüncelle.KategoriId = product.KategoriId;
            productgüncelle.Productadı = product.Productadı;
            productgüncelle.ProductFiyat = product.ProductFiyat;
            productgüncelle.Stok = product.Stok;

               







        }

        public void yoket(Product product)
        {
            Product productyoket = null;
            foreach (var p in _products )
            {
                if (product.ProductId==p.ProductId)
                {

                    productyoket = p;

                }

                
            }
            productyoket = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);


            _products.Remove(productyoket);
     
        }
         public List<Product> getallbycategory(int categoryId)
        {

          return  _products.Where(p => p.KategoriId ==categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }



        }



 
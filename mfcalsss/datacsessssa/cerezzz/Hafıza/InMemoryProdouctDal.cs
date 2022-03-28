using datacsessssa.ana;
using System;
using System.Collections.Generic;
using System.Linq;
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
              new Product {Productadı="aaaaaaa",ProductFiyat=15,ProductId=1,KategoriId=6,Stok=80 }




             };
 }

        public void Ekle(Product products)
        {
            _products.Add(products);
        }

        public List<Product> getAll()
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

    }



        }



 
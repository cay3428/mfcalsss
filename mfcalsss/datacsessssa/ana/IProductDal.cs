using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;

namespace datacsessssa.ana
{
   public interface IProductDal
    {

        List<Product> getAll();

        void Ekle(Product product);
        void güncelle(Product product);
        void yoket(Product product);

        List<Product> Getallbycategory(int categoryId);





    }
}

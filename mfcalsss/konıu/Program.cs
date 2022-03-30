using busiziii.concan;
using datacsessssa.ana;
using datacsessssa.cerezzz.Hafıza;
 
using System;
using DataAccsess.cerezzz.EntityFramework;

namespace konıu
{
    class Program
    {
        static void Main(string[] args)
        {


            ProductTest();

        }
        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }
        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())//GetAll
            {

                Console.WriteLine(product.ProductName + "/" + product.CategoryName);


            }
        }

    }
}

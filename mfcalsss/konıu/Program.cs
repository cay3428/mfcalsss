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
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {

                Console.WriteLine(product.Productadı);



            }
           




        }
    }
}

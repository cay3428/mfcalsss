using Autofac;
using Autofac.Extras.DynamicProxy;
using busiziii.absc;
using busiziii.concan;
using Castle.DynamicProxy;
using DataAccsess.ana;
using DataAccsess.cerezzz.EntityFramework;
using datacsessssa.ana;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Interceptor;
using busiziii.CCS;

namespace busiziii.DependencyResolver.Autofac
{
   public  class AutofacBusinessModule :Module

    { 
     

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal >().SingleInstance();
           
            builder.RegisterType<CategoryManager>().As<ICategoryService >().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<FileLogger>().As<ILogger>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();




        }

    } 
}

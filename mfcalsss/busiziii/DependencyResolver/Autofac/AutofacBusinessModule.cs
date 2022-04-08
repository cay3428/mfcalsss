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
using Core.Utilities;
using busiziii.CCS;
using Core.Utilities.Interceptors;
using Business.Concrete;
using Core.Utilities.Security.JWT;

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

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();




        }

    } 
}

﻿using Autofac;
using busiziii.absc;
using busiziii.concan;
using DataAccsess.cerezzz.EntityFramework;
using datacsessssa.ana;
using System;
using System.Collections.Generic;
using System.Text;

namespace busiziii.DependencyResolver.Autofac
{
   public  class AutofacBusinessModule :Module 

       
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal >().SingleInstance();


        }

    }
}
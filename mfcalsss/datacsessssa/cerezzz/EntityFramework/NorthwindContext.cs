﻿using Core.Entities.Concrete;
using Entities.cerezz;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;


namespace DataAccsess.cerezzz.EntityFramework
{
   public  class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true ");

        }
          public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
            public DbSet <Customer>customer { get; set; }
            public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaims> OperationClaims { get; set; }
         public DbSet<User >Users { get; set; }
         public DbSet<UserOperationClaims> UserOperationClaims { get; set; }

        





        }
    }


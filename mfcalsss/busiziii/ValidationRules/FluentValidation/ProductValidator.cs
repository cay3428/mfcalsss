﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;

namespace busiziii.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice ).GreaterThan(0);
            RuleFor(p => p.UnitPrice).NotEmpty ();
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p=>p.CategoryID==1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("ürünler a harfi ile başlamalı"); 






        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

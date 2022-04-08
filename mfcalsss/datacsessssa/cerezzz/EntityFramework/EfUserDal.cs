﻿using Core.DataAccsess.EntityFramework;
using Core.Entities.Concrete;
using DataAccsess.ana;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
 
namespace DataAccsess.cerezzz.EntityFramework
{
    public class EfUserDal : EfEntityResporityBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
    
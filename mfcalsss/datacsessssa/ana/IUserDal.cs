using Core.DataAccsess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.ana
{
    public  interface IUserDal : IEntityRespository<User>
    {



        List<OperationClaims> GetClaims(User user);






    }
}

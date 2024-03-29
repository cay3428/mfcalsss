﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace busiziii.absc
{
    public interface IUserService
    {
        List<OperationClaims> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}

using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;
 
using busiziii.contan;

namespace busiziii.BusinessAspects.Autofac
{
public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor  _httpContextAccesor;

        public SecuredOperation (string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccesor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();



        }
        protected override void OnBefore(IInvocation ınvocation)
        {
            var roleClaims = _httpContextAccesor.HttpContext.User.ClaimRoles();

            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {

                    return;

                }


            }

            throw new Exception(Messages.AuthorizationDenied);






        }




    }
}

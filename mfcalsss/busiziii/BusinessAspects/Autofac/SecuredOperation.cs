using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;

namespace busiziii.BusinessAspects.Autofac
{
public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccesor  _httpContextAccesor;

        public SecuredOperation (string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccesor = ServiceTool.ServiceProvider.GetService<IHttpContextAccesor>();



        }
         protected override void OnBefore(IInvocation ınvocation)
        {
            var roleClaims = _httpContextAccesor.HttpContext.User.ClaimRoles();

            foreach (var role in _roles )
            {
                if(roleClaims.Contains(role))
                {

                    return;

                }


            }

            throw new Exception(Messages.AuthorizationDenied);

        }




    }
}

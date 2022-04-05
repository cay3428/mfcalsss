using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Core.Utilities.Interceptor
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method ,AllowMultiple =true,Inherited = true)]

    public abstract class MethodInterceptionBaseAttribute :Attribute,IInterceptor
    {
        public int Priority { get; set; 
        }

        public virtual void Intercept (IInvocation ınvocation)
        {

        }

    }

    public class AspectInterceptorSelector : IInterceptorSelector
     {
         public IInterceptor [] SelectInterceptors(Type type,MethodInfo method,IInterceptor[] ınterceptors)
        {

            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
           
            return classAttributes.OrderBy(x => x.Priority).ToArray();




            // classAttributes.Add(new ExpentionLogAspect)(typeof(FileLogger)));







        }

    }
        

}

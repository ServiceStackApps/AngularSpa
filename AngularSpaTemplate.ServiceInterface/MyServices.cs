using System;
using ServiceStack;
using AngularSpaTemplate.ServiceModel;

namespace AngularSpaTemplate.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}

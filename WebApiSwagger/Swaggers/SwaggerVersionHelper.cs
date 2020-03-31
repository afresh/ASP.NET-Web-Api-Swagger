using System;
using System.Linq;
using System.Web.Http.Description;

namespace WebApiSwagger.Swagger
{
    public class SwaggerVersionHelper
    {
        public static bool ResolveVersionSupportByRouteConstraint(ApiDescription apiDesc, string targetApiVersion)
        {
            var attr = apiDesc.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<VersionedRoute>().FirstOrDefault();
            return attr != null && attr.Version == Convert.ToInt32(targetApiVersion.TrimStart('v'));
        }
    }
}
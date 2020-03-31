using System.Web.Http;
using WebApiSwagger.Swagger;

namespace WebApiSwagger.Controllers.v2
{
    /// <summary>
    /// 测试
    /// </summary>
    [VersionedRoute("api/version", 2)]
    public class TestController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Test()
        {
            return "测试";
        }
    }
}
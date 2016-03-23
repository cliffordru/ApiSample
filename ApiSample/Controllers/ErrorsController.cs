using ApiSample.Helpers;
using System.Web.Http;

namespace ApiSample.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/errors")]
    public class ErrorsController : BaseApiController
    {
        [Route("404")]
        [HttpGet]
        public IHttpActionResult Custom404()
        {
            return Json(new GlobalExceptionHandler.CustomApiError() { Info = "404", Message = "Resource Not Found" });
        }
    }
}

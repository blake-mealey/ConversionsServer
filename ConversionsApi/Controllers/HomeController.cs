using Microsoft.AspNetCore.Mvc;

namespace Chimerical.Conversions.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetHome()
        {
            return "ConversionsApi";
        }
    }
}
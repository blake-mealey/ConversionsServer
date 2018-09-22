using Microsoft.AspNetCore.Mvc;

namespace ConversionsApi.Controllers
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
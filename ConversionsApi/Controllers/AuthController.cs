using System.Threading.Tasks;
using Chimerical.Conversions.Api.Helpers;
using Chimerical.Conversions.Api.Services;
using Chimerical.Conversions.ClientModels.Models.Auth;
using Microsoft.AspNetCore.Mvc;

namespace ConversionsApi.Controllers
{
    [Route("api/[Controller]")]
    [ExceptionFilters]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("Token")]
        public async Task<ActionResult<UserAuthModel>> PostToken(AuthParameters authParameters)
        {
            var authToken = await _authService.ExchangeCodeForToken(authParameters);

            return Ok(authToken);
        }
    }
}
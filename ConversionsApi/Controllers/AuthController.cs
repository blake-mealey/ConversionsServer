using System;
using System.Threading.Tasks;
using Chimerical.Conversions.Api.Helpers;
using Chimerical.Conversions.Api.Services;
using Chimerical.Conversions.ClientModels.Models.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Chimerical.Conversions.Api.Controllers
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

        [HttpGet]
        [Route("IdentityProviders")]
        public async Task<ActionResult<IdentityProviderModel>> GetIdentityProviders()
        {
            var identityProviders = await _authService.GetIdentityProviders();

            return Ok(identityProviders);
        }
    }
}
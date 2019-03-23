using Chimerical.Conversions.ClientModels.Models.Auth;
using Newtonsoft.Json;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Chimerical.Conversions.Api.Helpers;
using Microsoft.Extensions.Configuration;

namespace Chimerical.Conversions.Api.Services
{
    public interface IAuthService
    {
        Task<UserAuthModel> ExchangeCodeForToken(AuthParameters authParameters);
    }

    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<UserAuthModel> ExchangeCodeForToken(AuthParameters authParameters)
        {
            var httpClient = new HttpClient();

            var authCode = new AuthCodeModel
            {
                Code = authParameters.Code,
                ClientId = authParameters.ClientId,
                ClientSecret = _configuration["GoogleOpenIdConnectClientSecret"],
                RedirectUri = authParameters.RedirectUri,
                GrantType = GrantType.AuthorizationCode
            };

            var data = new StringContent(JsonConvert.SerializeObject(authCode), Encoding.UTF8, "application/json");
            var request = await httpClient.PostAsync($"https://oauth2.googleapis.com/token",
                data);

            var content = await request.Content.ReadAsStringAsync();
            var authToken = JsonConvert.DeserializeObject<AuthTokenModel>(content);

            if (authParameters.Nonce != authToken.IdToken.Payload.Nonce) {
                throw new AuthenticationException($"The provided nonce {authParameters.Nonce} did match the nonce returned from the identity provider.");
            }

            return new UserAuthModel
            {
                AccessToken = authToken.AccessToken,
                DisplayName = authToken.IdToken.GetClaim(JwtSecurityTokenClaimType.Name),
                ProfilePictureUrl = authToken.IdToken.GetClaim(JwtSecurityTokenClaimType.Picture)
            };
        }
    }
}

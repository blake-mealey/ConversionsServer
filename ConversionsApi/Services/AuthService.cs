using System.Collections.Generic;
using System.Linq;
using Chimerical.Conversions.ClientModels.Models.Auth;
using Newtonsoft.Json;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Chimerical.Conversions.Api.Converters.Auth;
using Chimerical.Conversions.Api.Helpers;
using Chimerical.Conversions.Dal.Dals.Auth;
using Microsoft.Extensions.Configuration;

namespace Chimerical.Conversions.Api.Services
{
    public interface IAuthService
    {
        Task<UserAuthModel> ExchangeCodeForToken(AuthParameters authParameters);

        Task<List<IdentityProviderModel>> GetIdentityProviders();
    }

    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        private readonly IIdentityProviderDal _identityProviderDal;
        private readonly IIdentityProviderDiscoveryService _identityProviderDiscoveryService;

        public AuthService(HttpClient httpClient, IConfiguration configuration,
            IIdentityProviderDal identityProviderDal,
            IIdentityProviderDiscoveryService identityProviderDiscoveryService)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _identityProviderDal = identityProviderDal;
            _identityProviderDiscoveryService = identityProviderDiscoveryService;
        }

        public async Task<UserAuthModel> ExchangeCodeForToken(AuthParameters authParameters)
        {
            var identityProvider = await _identityProviderDal.GetIdentityProvider(authParameters.ClientId);
            var discoveryDocument = await _identityProviderDiscoveryService.GetDiscoveryDocument(identityProvider);

            var authCode = new AuthCodeModel
            {
                Code = authParameters.Code,
                ClientId = authParameters.ClientId,
                ClientSecret = identityProvider.ClientSecret,
                RedirectUri = authParameters.RedirectUri,
                GrantType = GrantType.AuthorizationCode
            };

            var data = new StringContent(JsonConvert.SerializeObject(authCode), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(discoveryDocument.TokenEndpoint, data);

            var content = await response.Content.ReadAsStringAsync();
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

        public async Task<List<IdentityProviderModel>> GetIdentityProviders()
        {
            var identityProviders = await _identityProviderDal.GetIdentityProviders();

            return identityProviders.Select(async x =>
                    x.ToClientModel(await _identityProviderDiscoveryService.GetDiscoveryDocument(x)))
                .Select(t => t.Result)
                .ToList();
        }
    }
}

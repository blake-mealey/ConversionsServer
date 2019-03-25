using System;
using System.Net.Http;
using System.Threading.Tasks;
using Chimerical.Conversions.ClientModels.Models.Auth;
using Chimerical.Conversions.Dal.Entities.Auth;
using Newtonsoft.Json;

namespace Chimerical.Conversions.Api.Services
{
    public interface IIdentityProviderDiscoveryService
    {
        Task<DiscoveryDocument> GetDiscoveryDocument(IdentityProviderEntity identityProvider);
    }

    public class IdentityProviderDiscoveryService : IIdentityProviderDiscoveryService
    {
        private static readonly TimeSpan DiscoveryDocumentLifeTime = TimeSpan.FromDays(0.5);

        private readonly HttpClient _httpClient;
        private readonly ITimeExpiryDataCacheService<DiscoveryDocument> _dataCache;

        public IdentityProviderDiscoveryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _dataCache = new TimeExpiryDataCacheService<DiscoveryDocument>(DiscoveryDocumentLifeTime);
        }

        public async Task<DiscoveryDocument> GetDiscoveryDocument(IdentityProviderEntity identityProvider)
        {
            return await _dataCache.GetDataAsync(identityProvider.ClientId, async () =>
            {
                var response = await _httpClient.GetAsync(identityProvider.DiscoveryUrl);

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<DiscoveryDocument>(content);
            });
        }
    }
}

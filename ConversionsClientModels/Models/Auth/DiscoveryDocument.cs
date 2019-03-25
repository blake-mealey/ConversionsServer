using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Chimerical.Conversions.ClientModels.Models.Auth
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class DiscoveryDocument
    {
        public string AuthorizationEndpoint { get; set; }

        public string TokenEndpoint { get; set; }
    }
}

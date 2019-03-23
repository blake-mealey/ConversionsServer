using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Chimerical.Conversions.ClientModels.Models.Auth
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class AuthParameters
    {
        public string ClientId { get; set; }

        public Uri RedirectUri { get; set; }

        public string Code { get; set; }

        public string Nonce { get; set; }
    }
}

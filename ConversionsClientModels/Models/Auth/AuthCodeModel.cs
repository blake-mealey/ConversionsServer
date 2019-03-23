using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Runtime.Serialization;

namespace Chimerical.Conversions.ClientModels.Models.Auth
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GrantType
    {
        [EnumMember(Value = "authorization_code")]
        AuthorizationCode
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class AuthCodeModel
    {
        public string Code { get; set; }
        
        public string ClientId { get; set; }
        
        public string ClientSecret { get; set; }
        
        public Uri RedirectUri { get; set; }

        public GrantType GrantType { get; set; }
    }
}

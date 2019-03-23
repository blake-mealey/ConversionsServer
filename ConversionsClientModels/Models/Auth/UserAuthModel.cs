using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Chimerical.Conversions.ClientModels.Models.Auth
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class UserAuthModel
    {
        public string AccessToken { get; set; }

        public string DisplayName { get; set; }

        public string ProfilePictureUrl { get; set; }
    }
}

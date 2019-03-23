using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.IdentityModel.Tokens.Jwt;

namespace Chimerical.Conversions.ClientModels.Models.Auth
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class AuthTokenModel
    {
        public string AccessToken { get; set; }

        [JsonProperty("id_token")]
        public string RawIdToken { get; set; }

        private JwtSecurityToken _idToken;

        [JsonIgnore]
        public JwtSecurityToken IdToken => _idToken ?? (_idToken = new JwtSecurityToken(RawIdToken));

        public double ExpiresIn { get; set; }

        public TokenType TokenType { get; set; }

        public string RefreshToken { get; set; }
    }
}

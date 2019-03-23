using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Chimerical.Conversions.Api.Helpers
{
    public static class JwtSecurityTokenClaimType
    {
        public const string Name = "name";
        public const string Picture = "picture";
    }

    public static class JwtSecurityTokenExtensions
    {
        public static string GetClaim(this JwtSecurityToken token, string type)
        {
            return token.Claims.FirstOrDefault(c => c.Type == type)?.Value;
        }
    }
}

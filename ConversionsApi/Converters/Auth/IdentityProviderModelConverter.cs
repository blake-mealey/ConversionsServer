using Chimerical.Conversions.ClientModels.Models.Auth;
using Chimerical.Conversions.Dal.Entities.Auth;

namespace Chimerical.Conversions.Api.Converters.Auth
{
    public static class IdentityProviderModelConverter
    {
        public static IdentityProviderModel ToClientModel(this IdentityProviderEntity entity, DiscoveryDocument discoveryDocument)
        {
            return new IdentityProviderModel
            {
                ClientId = entity.ClientId,
                DisplayName = entity.DisplayName,
                IconUrl = entity.IconUrl,
                AuthorizeUrl = discoveryDocument.AuthorizationEndpoint
            };
        }
    }
}

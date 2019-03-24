namespace Chimerical.Conversions.Dal.Entities.Auth
{
    public class IdentityProviderEntity
    {
        public string ClientId { get; set; }
        
        public string ClientSecret { get; set; }
        
        public string DiscoveryUrl { get; set; }

        public string DisplayName { get; set; }
        
        public string IconUrl { get; set; }
    }
}

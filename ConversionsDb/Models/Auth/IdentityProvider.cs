using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chimerical.Conversions.Db.Models.Auth
{
    [Table(nameof(IdentityProvider), Schema = "Auth")]
    public class IdentityProvider
    {
        [Key]
        [MaxLength(2000)]
        public string ClientId { get; set; }
        
        [Required]
        [MaxLength(2000)]
        public string ClientSecret { get; set; }
        
        [Required]
        [MaxLength(2000)]
        public string DiscoveryUrl { get; set; }

        [Required]
        [MaxLength(64)]
        public string DisplayName { get; set; }
        
        [Required]
        [MaxLength(2000)]
        public string IconUrl { get; set; }
    }
}

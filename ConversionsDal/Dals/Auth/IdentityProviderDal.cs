using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chimerical.Conversions.Dal.Entities.Auth;
using Chimerical.Conversions.Db;
using Chimerical.Conversions.Db.Models.Auth;
using Microsoft.EntityFrameworkCore;

namespace Chimerical.Conversions.Dal.Dals.Auth
{
    public interface IIdentityProviderDal
    {
        Task<IdentityProviderEntity> GetIdentityProvider(string clientId);

        Task<List<IdentityProviderEntity>> GetIdentityProviders();
    }

    public class IdentityProviderDal : BaseDal, IIdentityProviderDal
    {
        private readonly ConversionsContext _db;

        public IdentityProviderDal(ConversionsContext db)
        {
            _db = db;
        }

        public async Task<IdentityProviderEntity> GetIdentityProvider(string clientId)
        {
            try
            {
                return ToEntity(await _db.IdentityProviders.SingleAsync(x => x.ClientId == clientId));
            }
            catch (InvalidOperationException e)
            {
                throw new DataNotFoundException("IdentityProvider", clientId, e);
            }
        }

        public async Task<List<IdentityProviderEntity>> GetIdentityProviders()
        {
            return await _db.IdentityProviders.Select(x => ToEntity(x)).ToListAsync();
        }

        private static IdentityProviderEntity ToEntity(IdentityProvider identityProvider)
        {
            return new IdentityProviderEntity
            {
                ClientId = identityProvider.ClientId,
                ClientSecret = identityProvider.ClientSecret,
                DisplayName = identityProvider.DisplayName,
                DiscoveryUrl = identityProvider.DiscoveryUrl,
                IconUrl = identityProvider.IconUrl
            };
        }
    }
}

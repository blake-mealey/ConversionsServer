using System;
using System.Threading.Tasks;
using Chimerical.Conversions.Dal.Entities.Auth;
using Chimerical.Conversions.Db;
using Microsoft.EntityFrameworkCore;

namespace Chimerical.Conversions.Dal.Dals.Auth
{
    public interface IIdentityProviderDal
    {
        Task<IdentityProviderEntity> GetIdentityProvider(string clientId);
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
                var model =  await _db.IdentityProviders.SingleAsync(x => x.ClientId == clientId);
                return new IdentityProviderEntity
                {
                    ClientId = model.ClientId,
                    ClientSecret = model.ClientSecret,
                    DisplayName = model.DisplayName,
                    DiscoveryUrl = model.DiscoveryUrl,
                    IconUrl = model.IconUrl
                };
            }
            catch (InvalidOperationException e)
            {
                throw new DataNotFoundException("IdentityProvider", clientId, e);
            }
        }
    }
}

using Chimerical.Conversions.Dal.Entities.Conversions;
using Chimerical.Conversions.Db;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Chimerical.Conversions.Dal.Dals.Conversions
{
    public interface IConversionDal
    {
        List<ConversionEntity> GetConversions(int unitTypeId);
    }

    public class ConversionDal : BaseDal, IConversionDal
    {
        private readonly ConversionsContext _db;

        public ConversionDal(ConversionsContext db)
        {
            _db = db;
        }

        public List<ConversionEntity> GetConversions(int unitTypeId)
        {
            var result = (from c in _db.Conversions
                          join utm in _db.UnitTypeMaps on c.FromUnit.Symbol equals utm.Unit.Symbol
                          join utm2 in _db.UnitTypeMaps on c.ToUnit.Symbol equals utm2.Unit.Symbol
                          where utm.UnitType.Id == unitTypeId && utm2.UnitType.Id == unitTypeId
                          select c)
                .Include(rv => rv.FromUnit)
                .Include(rv => rv.ToUnit);

            return result.Select(conversion => new ConversionEntity(conversion)).ToList();
        }
    }
}

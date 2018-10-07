using Chimerical.Conversions.Dal.Entities.Conversions;
using Chimerical.Conversions.Db;
using System.Collections.Generic;
using System.Linq;

namespace Chimerical.Conversions.Dal.Dals.Conversions
{
    public interface IUnitDal
    {
        List<UnitEntity> GetUnits(int unitTypeId);
    }

    public class UnitDal : BaseDal, IUnitDal
    {
        private readonly ConversionsContext _db;

        public UnitDal(ConversionsContext db)
        {
            _db = db;
        }

        public List<UnitEntity> GetUnits(int unitTypeId)
        {
            return (from u in _db.Units
                    join utm in _db.UnitTypeMaps on u.Symbol equals utm.UnitSymbol
                    where utm.UnitTypeId == unitTypeId
                    orderby u.DisplayName, u.Symbol
                    select new UnitEntity(u)).ToList();
        }
    }
}

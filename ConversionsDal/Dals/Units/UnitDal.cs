using ConversionsDal.Entities.Units;
using ConversionsDb;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsDal.Dals.Units
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
                    join utm in _db.UnitTypeMaps on u.Id equals utm.UnitId
                    where utm.UnitTypeId == unitTypeId
                    select new UnitEntity(u)).ToList();
        }
    }
}

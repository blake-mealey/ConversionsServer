using ConversionsDal.Entities.Conversions;
using ConversionsDb;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsDal.Dals.Conversions
{
    public interface IUnitTypeDal
    {
        List<UnitTypeEntity> GetAllUnitTypes();
    }

    public class UnitTypeDal : IUnitTypeDal
    {
        private readonly ConversionsContext _db;

        public UnitTypeDal(ConversionsContext db)
        {
            _db = db;
        }

        public List<UnitTypeEntity> GetAllUnitTypes()
        {
            return (from bum in _db.BaseUnitMaps
                    join ut in _db.UnitTypes on bum.UnitTypeId equals ut.Id
                    join bu in _db.Units on bum.BaseUnitSymbol equals bu.Symbol
                    orderby ut.DisplayName, ut.Id
                    select new UnitTypeEntity(ut, bu,
                        from u in _db.Units
                        join utm in _db.UnitTypeMaps on u.Symbol equals utm.UnitSymbol
                        where utm.UnitTypeId == ut.Id
                        select u)).ToList();
        }
    }
}

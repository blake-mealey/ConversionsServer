using ConversionsDal.Entities.Units;
using ConversionsDb;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsDal.Dals.Units
{
    public interface IUnitTypeDal
    {
        List<UnitTypeEntity> GetAllUnitTypes();
    }

    public class UnitTypeDal : IUnitTypeDal
    {
        private readonly ConversionsContext _db;
        private readonly IUnitDal _unitDal;

        public UnitTypeDal(ConversionsContext db, IUnitDal unitDal)
        {
            _db = db;
            _unitDal = unitDal;
        }

        public List<UnitTypeEntity> GetAllUnitTypes()
        {
            var allUnits = _unitDal.GetAllUnits();

            return (from bum in _db.BaseUnitMaps
                    join ut in _db.UnitTypes on bum.UnitTypeId equals ut.Id
                    join bu in allUnits on bum.BaseUnitId equals bu.Id
                    select new UnitTypeEntity(ut, bu, from utm in _db.UnitTypeMaps
                                                      join ut2 in _db.UnitTypes on new { ut.Id, utm.UnitTypeId } equals new { ut2.Id, UnitTypeId = ut.Id }
                                                      join u in allUnits on utm.UnitId equals u.Id
                                                      select u)).ToList();
        }
    }
}

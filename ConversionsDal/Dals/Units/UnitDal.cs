using ConversionsDal.Entities.Units;
using ConversionsDb;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsDal.Dals.Units
{
    public interface IUnitDal
    {
        List<UnitEntity> GetAllUnits();
    }

    public class UnitDal : BaseDal, IUnitDal
    {
        private readonly ConversionsContext _db;

        public UnitDal(ConversionsContext db)
        {
            _db = db;
        }

        public List<UnitEntity> GetAllUnits()
        {
            return (from u in _db.Units
                    select new UnitEntity(u, from rv in _db.RelativeValues
                                             join u2 in _db.Units on new { u.Id, rv.UnitId } equals new { u2.Id, UnitId = u.Id }
                                             select rv)).ToList();
        }
    }
}

using ConversionsApi.Converters.Units;
using ConversionsClientModels.Models.Units;
using ConversionsDal.Dals.Units;
using System.Collections.Generic;

namespace ConversionsApi.Services.Units
{
    public interface IUnitsService
    {
        List<UnitClientModel> GetAllUnits();

        List<UnitTypeClientModel> GetAllUnitTypes();
    }

    public class UnitsService : IUnitsService
    {
        private readonly IUnitDal _unitDal;
        private readonly IUnitTypeDal _unitTypeDal;

        public UnitsService(IUnitDal unitDal, IUnitTypeDal unitTypeDal)
        {
            _unitDal = unitDal;
            _unitTypeDal = unitTypeDal;
        }

        public List<UnitClientModel> GetAllUnits()
        {
            return _unitDal.GetAllUnits().ToClientModels();
        }

        public List<UnitTypeClientModel> GetAllUnitTypes()
        {
            return _unitTypeDal.GetAllUnitTypes().ToClientModels();
        }
    }
}

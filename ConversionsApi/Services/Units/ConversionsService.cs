using ConversionsApi.Converters.Units;
using ConversionsClientModels.Models.Units;
using ConversionsDal.Dals.Units;
using ConversionsDal.Entities.Units;
using System.Collections.Generic;

namespace ConversionsApi.Services.Units
{
    public interface IConversionsService
    {
        List<UnitTypeConversionGraphClientModel> GetAllUnitTypesConversionGraphs();
    }

    public class ConversionsService : IConversionsService
    {
        private readonly IUnitDal _unitDal;
        private readonly IUnitTypeDal _unitTypeDal;
        private readonly IConversionDal _conversionDal;

        public ConversionsService(IUnitDal unitDal, IUnitTypeDal unitTypeDal, IConversionDal conversionDal)
        {
            _unitDal = unitDal;
            _unitTypeDal = unitTypeDal;
            _conversionDal = conversionDal;
        }

        public List<UnitTypeConversionGraphClientModel> GetAllUnitTypesConversionGraphs()
        {
            var unitTypes = _unitTypeDal.GetAllUnitTypes();

            var models = new List<UnitTypeConversionGraphClientModel>();
            foreach (var unitType in unitTypes)
            {
                models.Add(GetUnitTypeConversionGraph(unitType));
            }
            return models;
        }

        private UnitTypeConversionGraphClientModel GetUnitTypeConversionGraph(UnitTypeEntity unitType)
        {
            var conversionsGraph = new Dictionary<int, Dictionary<int, double>>();

            var conversions = _conversionDal.GetConversions(unitType.Id);
            foreach (var conversion in conversions)
            {
                AddConversion(conversionsGraph, conversion.FromUnit, conversion.ToUnit, conversion.Multiplier);
                AddConversion(conversionsGraph, conversion.ToUnit, conversion.FromUnit, 1.0 / conversion.Multiplier);
            }

            return new UnitTypeConversionGraphClientModel
            {
                UnitType = unitType.ToClientModel(),
                ConversionGraph = conversionsGraph
            };
        }

        private static void AddConversion(Dictionary<int, Dictionary<int, double>> graph, UnitEntity fromUnit,
            UnitEntity toUnit, double multiplier)
        {
            if (!graph.TryGetValue(fromUnit.Id, out var map))
            {
                map = new Dictionary<int, double>();
                graph[fromUnit.Id] = map;
            }

            map[toUnit.Id] = multiplier;
        }
    }
}

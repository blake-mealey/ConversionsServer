using ConversionsClientModels.Models.Units;
using ConversionsDal.Entities.Units;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsApi.Converters.Units
{
    public static class UnitTypeClientModelConverter
    {
        public static List<UnitTypeClientModel> ToClientModels(this IEnumerable<UnitTypeEntity> entities)
        {
            return entities.Select(ToClientModel).ToList();
        }

        public static UnitTypeClientModel ToClientModel(this UnitTypeEntity entity)
        {
            return new UnitTypeClientModel
            {
                DisplayName = entity.DisplayName,
                BaseUnitId = entity.BaseUnit.Id,
                UnitIds = entity.Units.Select(x => x.Id).ToList()
            };
        }
    }
}

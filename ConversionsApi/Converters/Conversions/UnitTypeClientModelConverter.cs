using Chimerical.Conversions.ClientModels.Models.Conversions;
using Chimerical.Conversions.Dal.Entities.Conversions;
using System.Collections.Generic;
using System.Linq;

namespace Chimerical.Conversions.Api.Converters.Conversions
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
                BaseUnit = entity.BaseUnit.ToClientModel(),
                Units = entity.Units.ToClientModels()
            };
        }
    }
}

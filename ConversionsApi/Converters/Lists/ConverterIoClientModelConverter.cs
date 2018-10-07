using Chimerical.Conversions.ClientModels.Models.Lists;
using Chimerical.Conversions.Dal.Entities.Lists;
using System.Collections.Generic;
using System.Linq;

namespace Chimerical.Conversions.Api.Converters.Lists
{
    public static class ConverterIoClientModelConverter
    {
        public static List<ConverterInputClientModel> ToInputClientModels(this IEnumerable<ConverterIoEntity> entities)
        {
            return entities.Select(ToInputClientModel).ToList();
        }

        public static ConverterInputClientModel ToInputClientModel(this ConverterIoEntity entity)
        {
            return new ConverterInputClientModel
            {
                UnitSymbol = entity.Unit.Symbol,
                Value = entity.Value
            };
        }

        public static List<ConverterOutputClientModel> ToOutputClientModels(this IEnumerable<ConverterIoEntity> entities)
        {
            return entities.Select(ToOutputClientModel).ToList();
        }

        public static ConverterOutputClientModel ToOutputClientModel(this ConverterIoEntity entity)
        {
            return new ConverterOutputClientModel
            {
                Id = GuidConverter.EncodeGuid(entity.Id),
                UnitSymbol = entity.Unit.Symbol
            };
        }
    }
}

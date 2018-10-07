using ConversionsClientModels.Models.Lists;
using ConversionsDal.Entities.Lists;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsApi.Converters.Lists
{
    public static class ConverterClientModelConverter
    {
        public static List<ConverterClientModel> ToClientModels(this IEnumerable<ConverterEntity> entities)
        {
            return entities.Select(ToClientModel).ToList();
        }

        public static ConverterClientModel ToClientModel(this ConverterEntity entity)
        {
            return new ConverterClientModel
            {
                Id = GuidConverter.EncodeGuid(entity.Id),
                UnitTypeId = entity.UnitTypeId,
                Input = entity.Input.ToInputClientModel(),
                Outputs = entity.Outputs.ToOutputClientModels()
            };
        }
    }
}

using ConversionsDb.Models.Lists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsDal.Entities.Lists
{
    public class ConverterListEntity
    {
        public ConverterListEntity(ConverterList converterList, IEnumerable<ConverterEntity> convereters)
        {
            Id = converterList.Id;
            DisplayName = converterList.DisplayName;
            Converters = convereters.ToList();
        }

        public Guid Id;

        public string DisplayName;

        public List<ConverterEntity> Converters;
    }
}

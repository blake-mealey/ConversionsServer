using Chimerical.Conversions.Db.Models.Lists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chimerical.Conversions.Dal.Entities.Lists
{
    public class ConverterListEntity
    {
        public ConverterListEntity(ConverterList converterList, IEnumerable<ConverterEntity> converters)
        {
            Id = converterList.Id;
            DisplayName = converterList.DisplayName;
            Converters = converters.ToList();
        }

        public ConverterListEntity()
        {
        }

        public Guid Id;

        public string DisplayName;

        public List<ConverterEntity> Converters;
    }
}

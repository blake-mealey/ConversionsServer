using Chimerical.Conversions.Db.Models.Lists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chimerical.Conversions.Dal.Entities.Lists
{
    public class ConverterEntity
    {
        public ConverterEntity(Converter converter, ConverterIo input, IEnumerable<ConverterIo> outputs)
        {
            Id = converter.Id;
            UnitTypeId = converter.UnitTypeId;
            Input = new ConverterIoEntity(input);
            Outputs = outputs.Select(o => new ConverterIoEntity(o)).ToList();
        }

        public Guid Id;

        public int UnitTypeId;

        public ConverterIoEntity Input;

        public List<ConverterIoEntity> Outputs;
    }
}

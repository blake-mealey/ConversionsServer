using Chimerical.Conversions.Dal.Entities.Conversions;
using Chimerical.Conversions.Db.Models.Lists;
using System;

namespace Chimerical.Conversions.Dal.Entities.Lists
{
    public enum ConverterIoTypeEnum
    {
        Input = 1,
        Output = 2
    }

    public class ConverterIoEntity
    {
        public ConverterIoEntity(ConverterIo io)
        {
            Id = io.Id;
            Type = (ConverterIoTypeEnum)io.ConverterIoTypeId;
            Value = io.Value;
            Unit = new UnitEntity(io.Unit);
        }

        public Guid Id;

        public ConverterIoTypeEnum Type;

        public double Value;

        public UnitEntity Unit;
    }
}

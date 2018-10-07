using ConversionsDal.Entities.Conversions;
using ConversionsDb.Models.Lists;
using System;

namespace ConversionsDal.Entities.Lists
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

using Chimerical.Conversions.Db.Models.Lists;
using System.Collections.Generic;

namespace Chimerical.Conversions.Db.SeedData.Lists
{
    public static class ConverterIoTypeData
    {
        public static readonly ConverterIoType Input = new ConverterIoType
        {
            Id = 1,
            Name = "Input"
        };

        public static readonly ConverterIoType Output = new ConverterIoType
        {
            Id = 2,
            Name = "Output"
        };

        public static readonly List<ConverterIoType> ConverterIoTypes = new List<ConverterIoType>()
        {
            Input,
            Output
        };
    }
}

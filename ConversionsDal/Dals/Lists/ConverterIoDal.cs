using Chimerical.Conversions.Db;
using Chimerical.Conversions.Db.Models.Lists;
using System;

namespace Chimerical.Conversions.Dal.Dals.Lists
{
    public interface IConverterIoDal
    {
        Guid CreateConverterInput(Guid converterId, string unitSymbol, double value);
        Guid CreateConverterOutput(Guid converterId, string unitSymbol);
    }

    public class ConverterIoDal : IConverterIoDal
    {
        private readonly ConversionsContext _db;

        public ConverterIoDal(ConversionsContext db)
        {
            _db = db;
        }

        public Guid CreateConverterInput(Guid converterId, string unitSymbol, double value)
        {
            var id = Guid.NewGuid();
            _db.ConverterIos.Add(new ConverterIo
            {
                Id = id,
                ConverterId = converterId,
                ConverterIoTypeId = 1,
                UnitSymbol = unitSymbol,
                Value = value
            });
            _db.SaveChanges();
            return id;
        }

        public Guid CreateConverterOutput(Guid converterId, string unitSymbol)
        {
            var id = Guid.NewGuid();
            _db.ConverterIos.Add(new ConverterIo
            {
                Id = id,
                ConverterId = converterId,
                ConverterIoTypeId = 2,
                UnitSymbol = unitSymbol
            });
            _db.SaveChanges();
            return id;
        }
    }
}

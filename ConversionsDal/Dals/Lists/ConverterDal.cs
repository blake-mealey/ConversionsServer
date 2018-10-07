using Chimerical.Conversions.Db;
using Chimerical.Conversions.Db.Models.Lists;
using System;

namespace Chimerical.Conversions.Dal.Dals.Lists
{
    public interface IConverterDal
    {
        Guid CreateConverter(int unitTypeId);
    }

    public class ConverterDal : IConverterDal
    {
        private readonly ConversionsContext _db;

        public ConverterDal(ConversionsContext db)
        {
            _db = db;
        }

        public Guid CreateConverter(int unitTypeId)
        {
            var id = Guid.NewGuid();
            _db.Converters.Add(new Converter
            {
                Id = id,
                UnitTypeId = unitTypeId
            });
            _db.SaveChanges();
            return id;
        }
    }
}

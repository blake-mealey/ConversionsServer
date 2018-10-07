using ConversionsDal.Entities.Lists;
using ConversionsDb;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsDal.Dals.Lists
{
    public interface IConverterListDal
    {
        ConverterListEntity GetConverterList(Guid listId);
    }

    public class ConverterListDal : IConverterListDal
    {
        private readonly ConversionsContext _db;

        public ConverterListDal(ConversionsContext db)
        {
            _db = db;
        }

        public ConverterListEntity GetConverterList(Guid listId)
        {
            var res = from cl in _db.ConverterLists
                      where cl.Id == listId
                      select new ConverterListEntity(cl, from c in _db.Converters
                                                         join clm in _db.ConverterListMaps on c.Id equals clm.ConverterId
                                                         join ci in _db.ConverterIos on c.Id equals ci.ConverterId
                                                         where clm.ConverterListId == listId && ci.ConverterIoTypeId == (int)ConverterIoTypeEnum.Input
                                                         select new ConverterEntity(c, ci, from co in _db.ConverterIos
                                                                                           where co.ConverterId == c.Id && co.ConverterIoTypeId == (int)ConverterIoTypeEnum.Output
                                                                                           select co));
            var list = res.FirstOrDefault();
            if (list == null)
            {
                throw new DataNotFoundException(nameof(ConverterListEntity), listId.ToString());
            }

            return list;
        }
    }
}

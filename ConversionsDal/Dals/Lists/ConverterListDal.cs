using Chimerical.Conversions.Dal.Entities.Lists;
using Chimerical.Conversions.Db;
using Chimerical.Conversions.Db.Models.Lists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chimerical.Conversions.Dal.Dals.Lists
{
    public interface IConverterListDal
    {
        IEnumerable<ConverterListEntity> GetConverterListsPage(int pageIndex, int pageLength);

        ConverterListEntity GetConverterList(Guid listId);

        Guid CreateConverterList(string displayName);

        void AddConverterToList(Guid listId, Guid converterId);
    }

    public class ConverterListDal : IConverterListDal
    {
        private readonly ConversionsContext _db;

        private const int MaxPageLength = 100;

        public ConverterListDal(ConversionsContext db)
        {
            _db = db;
        }

        public IEnumerable<ConverterListEntity> GetConverterListsPage(int pageIndex, int pageLength)
        {
            if (pageIndex < 0)
            {
                throw new ArgumentException("Page index must be at least 0.");
            }

            if (pageLength < 0 || pageLength > MaxPageLength)
            {
                throw new ArgumentException($"Page length must be in the range [0, {MaxPageLength}].");
            }

            try
            {
                return (from cl in _db.ConverterLists
                        select new ConverterListEntity(cl, from c in _db.Converters
                                                           join clm in _db.ConverterListMaps on c.Id equals clm.ConverterId
                                                           where clm.ConverterListId == cl.Id
                                                           select new ConverterEntity(c,
                                                               (from ci in _db.ConverterIos
                                                                where ci.ConverterId == c.Id &&
                                       ci.ConverterIoTypeId == (int)ConverterIoTypeEnum.Input
                                                                select new ConverterIo
                                                                {
                                                                    Id = ci.Id,
                                                                    ConverterIoTypeId = ci.ConverterIoTypeId,
                                                                    Value = ci.Value,
                                                                    Unit = ci.Unit
                                                                }).First(),
                                                               from co in _db.ConverterIos
                                                               where co.ConverterId == c.Id && co.ConverterIoTypeId == (int)ConverterIoTypeEnum.Output
                                                               select new ConverterIo
                                                               {
                                                                   Id = co.Id,
                                                                   ConverterIoTypeId = co.ConverterIoTypeId,
                                                                   Value = co.Value,
                                                                   Unit = co.Unit
                                                               }))).OrderBy(cl => cl.Id)
                    .Skip(pageIndex * pageLength)
                    .Take(pageLength);
            }
            catch (Exception e)
            {
                throw new DataNotFoundException($"No {nameof(ConverterListEntity)} objects could be found.", e);
            }
        }

        public ConverterListEntity GetConverterList(Guid listId)
        {
            if (listId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(listId));
            }

            try
            {
                return (from cl in _db.ConverterLists
                        where cl.Id == listId
                        select new ConverterListEntity(cl, from c in _db.Converters
                                                           join clm in _db.ConverterListMaps on c.Id equals clm.ConverterId
                                                           where clm.ConverterListId == listId
                                                           select new ConverterEntity(c,
                                                               (from ci in _db.ConverterIos
                                                                where ci.ConverterId == c.Id && ci.ConverterIoTypeId == (int)ConverterIoTypeEnum.Input
                                                                select new ConverterIo
                                                                {
                                                                    Id = ci.Id,
                                                                    ConverterIoTypeId = ci.ConverterIoTypeId,
                                                                    Value = ci.Value,
                                                                    Unit = ci.Unit
                                                                }).First(),
                                                               from co in _db.ConverterIos
                                                               where co.ConverterId == c.Id && co.ConverterIoTypeId == (int)ConverterIoTypeEnum.Output
                                                               select new ConverterIo
                                                               {
                                                                   Id = co.Id,
                                                                   ConverterIoTypeId = co.ConverterIoTypeId,
                                                                   Value = co.Value,
                                                                   Unit = co.Unit
                                                               }))).First();
            }
            catch (Exception e)
            {
                throw new DataNotFoundException(nameof(ConverterListEntity), listId.ToString(), e);
            }
        }

        public Guid CreateConverterList(string displayName)
        {
            var id = Guid.NewGuid();
            _db.ConverterLists.Add(new ConverterList
            {
                Id = id,
                DisplayName = displayName
            });
            _db.SaveChanges();
            return id;
        }

        public void AddConverterToList(Guid listId, Guid converterId)
        {
            _db.ConverterListMaps.Add(new ConverterListMap
            {
                ConverterListId = listId,
                ConverterId = converterId
            });
            _db.SaveChanges();
        }
    }
}

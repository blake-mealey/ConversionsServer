using Chimerical.Conversions.Api.Converters.Lists;
using Chimerical.Conversions.ClientModels.Models.Lists;
using Chimerical.Conversions.Dal.Dals.Lists;
using System;

namespace Chimerical.Conversions.Api.Services
{
    public interface IListsService
    {
        ConverterListClientModel GetConverterList(Guid listId);
    }

    public class ListsService : IListsService
    {
        private IConverterListDal _converterListDal;

        public ListsService(IConverterListDal converterListDal)
        {
            _converterListDal = converterListDal;
        }

        public ConverterListClientModel GetConverterList(Guid listId)
        {
            return _converterListDal.GetConverterList(listId).ToClientModel();
        }
    }
}

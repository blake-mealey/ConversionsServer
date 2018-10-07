using ConversionsApi.Converters.Lists;
using ConversionsClientModels.Models.Lists;
using ConversionsDal.Dals.Lists;
using System;

namespace ConversionsApi.Services
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

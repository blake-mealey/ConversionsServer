using Chimerical.Conversions.Api.Converters.Lists;
using Chimerical.Conversions.ClientModels.Models.Lists;
using Chimerical.Conversions.Dal.Dals.Lists;
using System;
using System.Collections.Generic;

namespace Chimerical.Conversions.Api.Services
{
    public interface IListsService
    {
        List<SimpleConverterListClientModel> GetConverterListsPage(int pageIndex, int pageLength);

        ConverterListClientModel GetConverterList(Guid listId);

        ConverterListClientModel CreateConverterList(ConverterListClientModel converterListModel);
    }

    public class ListsService : IListsService
    {
        private readonly IConverterListDal _converterListDal;
        private readonly IConverterDal _converterDal;
        private readonly IConverterIoDal _converterIoDal;

        public ListsService(IConverterListDal converterListDal, IConverterIoDal converterIoDal, IConverterDal converterDal)
        {
            _converterListDal = converterListDal;
            _converterIoDal = converterIoDal;
            _converterDal = converterDal;
        }

        public List<SimpleConverterListClientModel> GetConverterListsPage(int pageIndex, int pageLength)
        {
            return _converterListDal.GetConverterListsPage(pageIndex, pageLength).ToSimpleClientModels();
        }

        public ConverterListClientModel GetConverterList(Guid listId)
        {
            return _converterListDal.GetConverterList(listId).ToClientModel();
        }

        public ConverterListClientModel CreateConverterList(ConverterListClientModel converterListModel)
        {
            // Inserte a ConverterList entry
            var converterListId = _converterListDal.CreateConverterList(converterListModel.DisplayName);

            foreach (var converterModel in converterListModel.Converters)
            {
                // Insert a Converter entry
                var converterId = _converterDal.CreateConverter(converterModel.UnitTypeId);

                // Insert a ConverterIo entry for the converter's input
                _converterIoDal.CreateConverterInput(converterId, converterModel.Input.UnitSymbol, converterModel.Input.Value);

                // Insert ConverterIo entries for the converter's outputs
                foreach (var outputModel in converterModel.Outputs)
                {
                    _converterIoDal.CreateConverterOutput(converterId, outputModel.UnitSymbol);
                }

                // Add the converter to the list
                _converterListDal.AddConverterToList(converterListId, converterId);
            }

            // Construct and return the entity for the new converter list
            return GetConverterList(converterListId);
        }
    }
}

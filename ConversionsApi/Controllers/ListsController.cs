using Chimerical.Conversions.Api.Converters;
using Chimerical.Conversions.Api.Helpers;
using Chimerical.Conversions.Api.Services;
using Chimerical.Conversions.ClientModels.Models.Lists;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Chimerical.Conversions.Api.Controllers
{
    [Route("api/[Controller]")]
    [ExceptionFilters]
    [ApiController]
    public class ListsController : ControllerBase
    {
        private readonly IListsService _listsService;

        public ListsController(IListsService listsService)
        {
            _listsService = listsService;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<ConverterListClientModel>> GetConverterListsPage(int pageIndex, int pageLength)
        {
            return _listsService.GetConverterListsPage(pageIndex, pageLength);
        }

        [HttpGet]
        [Route("{listId}")]
        public ActionResult<ConverterListClientModel> GetConverterList(string listId)
        {
            return _listsService.GetConverterList(GuidConverter.DecodeGuid(listId));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ConverterListClientModel> PostConverterList(ConverterListClientModel converterListModel)
        {
            return _listsService.CreateConverterList(converterListModel);
        }
    }
}
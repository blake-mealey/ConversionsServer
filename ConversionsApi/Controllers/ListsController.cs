using Chimerical.Conversions.Api.Converters;
using Chimerical.Conversions.Api.Helpers;
using Chimerical.Conversions.Api.Services;
using Chimerical.Conversions.ClientModels.Models.Lists;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Chimerical.Conversions.Api.Controllers
{
    [Route("api/[Controller]")]
    [ExceptionFilters]
    [ApiController]
    public class ListsController : ControllerBase
    {
        private readonly IListsService _listsService;
        private readonly ILogger<ListsController> _logger;

        public ListsController(IListsService listsService, ILogger<ListsController> logger)
        {
            _listsService = listsService;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<SimpleConverterListClientModel>> GetConverterListsPage(int pageIndex, int pageLength)
        {
            _logger.LogInformation($"GetConverterListsPage: PageIndex: {pageIndex} PageLength: {pageLength}");
            return _listsService.GetConverterListsPage(pageIndex, pageLength);
        }

        [HttpGet]
        [Route("{listId}")]
        public ActionResult<ConverterListClientModel> GetConverterList(string listId)
        {
            _logger.LogInformation($"GetConverterList: ListId: {listId}");
            return _listsService.GetConverterList(GuidConverter.DecodeGuid(listId));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ConverterListClientModel> PostConverterList(ConverterListClientModel converterListModel)
        {
            _logger.LogInformation($"PostConverterList: DisplayName: {converterListModel.DisplayName}");
            return _listsService.CreateConverterList(converterListModel);
        }
    }
}
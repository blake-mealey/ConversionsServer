using Chimerical.Conversions.Api.Converters;
using Chimerical.Conversions.Api.Helpers;
using Chimerical.Conversions.Api.Services;
using Chimerical.Conversions.ClientModels.Models.Lists;
using Microsoft.AspNetCore.Mvc;

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
        [Route("{listId}")]
        public ActionResult<ConverterListClientModel> GetAllUnitTypesConversionGraphs(string listId)
        {
            return _listsService.GetConverterList(GuidConverter.DecodeGuid(listId));
        }
    }
}
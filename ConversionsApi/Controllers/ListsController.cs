using ConversionsApi.Converters;
using ConversionsApi.Services;
using ConversionsClientModels.Models.Lists;
using Microsoft.AspNetCore.Mvc;

namespace ConversionsApi.Controllers
{
    [Route("api/[Controller]")]
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
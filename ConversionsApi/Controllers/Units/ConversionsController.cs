using ConversionsApi.Services.Units;
using ConversionsClientModels.Models.Units;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConversionsApi.Controllers.Units
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ConversionsController : ControllerBase
    {
        private readonly IConversionsService _conversionsService;

        public ConversionsController(IConversionsService conversionsService)
        {
            _conversionsService = conversionsService;
        }

        [HttpGet]
        [Route("Types/ConversionGraphs")]
        public ActionResult<List<UnitTypeConversionGraphClientModel>> GetAllUnitTypesConversionGraphs()
        {
            return _conversionsService.GetAllUnitTypesConversionGraphs();
        }

    }
}
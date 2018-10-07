using Chimerical.Conversions.Api.Services;
using Chimerical.Conversions.ClientModels.Models.Conversions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Chimerical.Conversions.Api.Controllers
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
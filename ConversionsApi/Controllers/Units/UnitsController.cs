using ConversionsApi.Services.Units;
using ConversionsClientModels.Models.Units;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsApi.Controllers.Units
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UnitsController : ControllerBase
    {
        private readonly IUnitsService _unitsService;

        public UnitsController(IUnitsService unitsService)
        {
            _unitsService = unitsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UnitClientModel>> GetAllUnits()
        {
            return _unitsService.GetAllUnits().ToList();
        }

        [HttpGet]
        [Route("Types")]
        public ActionResult<IEnumerable<UnitTypeClientModel>> GetAllUnitTypes()
        {
            return _unitsService.GetAllUnitTypes().ToList();
        }
    }
}
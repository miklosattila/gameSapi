using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Services.MapServices;
using Microsoft.AspNetCore.Mvc;

namespace Catolog.Controllers
{
    
    [ApiController]
    [Route("map/")]
    public class MapController : ControllerBase
    {
        private readonly IMapServices _mapServices;

        public MapController(IMapServices _mapServices)
        {
            this._mapServices = _mapServices;
        }

    [HttpGet("GetAllByPlayer/{id}")]
    public async Task<ActionResult<ServiceResponse<List<GetMapWithAllResourcesDto>>>> GetAllByPlayer(int id)
    {
        return Ok(await _mapServices.GetAllByPlayer(id));
    }
    
    [HttpGet("GetAllQuiz/{id}")]
    public async Task<ActionResult<ServiceResponse<List<GetMapWithAllResourcesDto>>>> GetAllQuiz(int id)
    {
        return Ok(await _mapServices.GetAllQuiz(id));
    }

    }
}
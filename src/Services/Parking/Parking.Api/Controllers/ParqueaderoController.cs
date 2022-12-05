using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Parking.Service.Queries.DTOs;
using Parking.Service.Queries.IServices;
using Service.Common.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Api.Controllers
{
    [ApiController]
    [Route("parqueadero")]
    public class ParqueaderoController : ControllerBase
    {
        private readonly IParqueaderoService _parqueaderoService;
        private readonly ILogger<ParqueaderoController> _logger;

        public ParqueaderoController(
            ILogger<ParqueaderoController> logger,
            IParqueaderoService parqueaderoService)
        {
            _logger = logger;
            _parqueaderoService = parqueaderoService;
        }

        // parqueadero
        [HttpGet]
        public async Task<DataCollection<ParqueaderoDto>> GetAllParqueaderos(int page=1, int take = 10, string ids = null)
        {
            IEnumerable<int> parqueadero = null;

            if (!string.IsNullOrEmpty(ids))
            {
                parqueadero = ids.Split(',').Select(x => Convert.ToInt32(x));
            }
            return await _parqueaderoService.GetAllParqueaderos(page, take, parqueadero);
        }

  

        // parqueadero/id
        [HttpGet("{id}")]
        public async Task<ParqueaderoDto> GetParqueadero(int id)
        {
            return await _parqueaderoService.GetParqueadero(id);
        }
    }
}

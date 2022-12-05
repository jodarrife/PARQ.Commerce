using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        private readonly ILogger<ParqueaderoController> _logger;

        public ParqueaderoController(ILogger<ParqueaderoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Running 3 2 1 ...  ";
        }
    }
}

using Api.Gateway.Models;
using Api.Gateway.Models.Parking.DTOs;
using Api.Gateway.Proxies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Gateway.WebClient.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("parqueadero")]
    public class ParkingController : ControllerBase
    {
        private readonly ICatalogProxy _catalogProxy;

        public ParkingController(
            ICatalogProxy catalogProxy
        ) 
        {
            _catalogProxy = catalogProxy;
        }

        [HttpGet]
        public async Task<DataCollection<ParqueaderoDto>> GetAll(int page, int take) 
        {
            return await _catalogProxy.GetAllAsync(page, take);
        }

        [HttpGet("{id}")]
        public async Task<ParqueaderoDto> Get(int id)
        {
            return await _catalogProxy.GetAsync(id);
        }
    }
}

using Entities.App.Chargers;
using Entities.App.Common;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.CpoControllers
{
    [ApiController]
    [Route("cpo/charger")]
    public class ChargerController : ControllerBase
    {
        [HttpPost("getCpos")]
        public ApiResponse<List<Cpo>> GetCpos(GetRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("getCpo/{cpoId}")]
        public ApiResponse<Cpo> GetCpo(string cpoId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("getChargers")]
        public ApiResponse<List<Charger>> GetChargers(GetRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("getCharger/{chargerId}")]
        public ApiResponse<Charger> GetCharger(string chargerId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("getLocations")]
        public ApiResponse<List<Location>> GetLocations(GetRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("getLocation/{locationId}")]
        public ApiResponse<Location> GetLocation(string locationId)
        {
            throw new NotImplementedException();
        }

    }
}

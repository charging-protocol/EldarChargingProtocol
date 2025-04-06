using Entities.App.Chargers;
using Entities.App.Common;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.AppControllers
{
    [ApiController]
    [Route("app/charger")]
    public class ChargerController : ControllerBase
    {
        [HttpPost("updateCpo")]
        public ApiResponse UpdateCpo(Cpo req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("deleteCpo/{cpoId}")]
        public ApiResponse DeleteCpo(string cpoId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("updateCharger")]
        public ApiResponse UpdateCharger(Charger req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("updateChargersStatus")]
        public ApiResponse UpdateChargersStatus(UpdateChargersStatusRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("deleteCharger/{chargerId}")]
        public ApiResponse DeleteCharger(string chargerId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("updateLocation")]
        public ApiResponse UpdateLocation(Location req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("deleteLocation/{locationId}")]
        public ApiResponse DeleteLocation(string locationId)
        {
            throw new NotImplementedException();
        }

    }
}

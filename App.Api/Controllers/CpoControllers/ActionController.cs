using Entities.App.Actions;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.CpoControllers
{
    [ApiController]
    [Route("cpo/action")]
    public class ActionController : ControllerBase
    {
        [HttpPost("start")]
        public StartResponse Start(StartRequest req)
        {
            throw new NotImplementedException();
        }
        [HttpPost("stop")]
        public StopResponse Stop(StopRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpPost("reserve")]
        public ReserveResponse Reserve(ReserveRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpPost("unReserve")]
        public UnReserveResponse UnReserve(UnReserveRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpPost("unlockConnector")]
        public UnlockConnectorResponse UnlockConnector(UnlockConnectorRequest req)
        {
            throw new NotImplementedException();
        }


    }
}

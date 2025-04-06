using Entities.App.Actions;
using Entities.App.Common;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.AppControllers
{
    [ApiController]
    [Route("app/late")]
    public class LateController : ControllerBase
    {

        [HttpPost("event")]
        public ApiResponse Event(EventRequest req)
        {
            throw new NotImplementedException();
        }


    }
}

using Entities.App.Common;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.AppControllers
{
    [ApiController]
    [Route("app")]
    public class CoreController : ControllerBase
    {
        [HttpGet("heartbeat")]
        public string Heartbeatet()
        {
            return DateTime.UtcNow.ToLongDateString();
        }

        [HttpGet("version")]
        public string Version()
        {
            return "1.0";
        }

        [HttpPost("updateToken")]
        public ApiResponse UpdateToken(UpdateTokenRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("disableToken")]
        public ApiResponse DisableToken()
        {
            throw new NotImplementedException();
        }
    }
}

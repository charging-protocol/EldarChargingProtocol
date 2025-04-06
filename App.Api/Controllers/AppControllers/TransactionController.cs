using Entities.App.Common;
using Entities.App.Transactions;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.AppControllers
{
    [ApiController]
    [Route("app/transaction")]
    public class TransactionController : ControllerBase
    {

        [HttpPost("upsertTransaction")]
        public ApiResponse UpsertTransaction(Transaction req)
        {
            throw new NotImplementedException();
        }


    }
}

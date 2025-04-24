using Entities.App.Common;
using Entities.App.Transactions;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.AppControllers
{
    [ApiController]
    [Route("app/transaction")]
    public class TransactionController : ControllerBase
    {

        [HttpPost("upsertTariff")]
        public ApiResponse UpsertTransaction(Transaction req)
        {
            throw new NotImplementedException();
        }

        [HttpPost("upsertTariff")]
        public ApiResponse UpsertTariff(Tariff req)
        {
            throw new NotImplementedException();
        }

        [HttpPost("upsertInvoice")]
        public ApiResponse UpsertInvoice(Invoice req)
        {
            throw new NotImplementedException();
        }


    }
}

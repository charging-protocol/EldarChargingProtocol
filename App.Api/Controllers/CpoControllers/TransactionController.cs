using Entities.App.Common;
using Entities.App.Transactions;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.CpoControllers
{
    [ApiController]
    [Route("cpo/transaction")]
    public class TransactionController : ControllerBase
    {
        [HttpPost("getTransactions")]
        public ApiResponse<List<Transaction>> GetTransactions(GetRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("getTransaction/{transactionId}")]
        public ApiResponse<Transaction> GetTransaction(string transactionId)
        {
            throw new NotImplementedException();
        }



    }
}

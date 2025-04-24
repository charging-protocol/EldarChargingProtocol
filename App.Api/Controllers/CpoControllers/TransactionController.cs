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

        [HttpPost("getTariffs")]
        public ApiResponse<List<Tariff>> GetTariffs(GetRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("tariff/{tariffId}")]
        public ApiResponse<Tariff> GetTariff(string tariffId)
        {
            throw new NotImplementedException();
        }


        [HttpPost("getInvoices")]
        public ApiResponse<List<Invoice>> GetInvoices(GetRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpGet("invoice/{invoiceId}")]
        public ApiResponse<Invoice> GetInvoice(string invoiceId)
        {
            throw new NotImplementedException();
        }


    }
}

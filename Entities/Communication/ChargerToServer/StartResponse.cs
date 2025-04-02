using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class StartResponse : SocketResponse
    {
        [Required, StringLength(100)]
        public string? ServerTransactionId { get; set; }

    }

    public enum StartCodeEnum : byte
    {
        Ok,
        Rejected,
    }
}

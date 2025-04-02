using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class UnReserveRequest : SocketRequest
    {
        [StringLength(100)]
        public string ServerTransactionId { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }
    }



}

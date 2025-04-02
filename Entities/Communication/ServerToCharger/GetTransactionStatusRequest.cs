using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class GetTransactionStatusRequest : SocketRequest
    {
        /// <summary>
        /// ID of the EVSE (Electric Vehicle Supply Equipment)
        /// </summary>
        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        /// <summary>
        ///  ID of a specific connector within the EVSE
        /// </summary>
        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }

        [StringLength(100)]
        public string? ServerTransactionId { get; set; }
    }




}
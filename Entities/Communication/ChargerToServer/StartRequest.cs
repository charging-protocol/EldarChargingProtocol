using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class StartRequest : SocketRequest
    {
        public bool? IsOffline { get; set; }

        [StringLength(100)]
        public string ServerTransactionId { get; set; }

        [Required, StringLength(100)]
        public string ChargerTransactionId { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int? RunningNumber { get; set; }

        /// <summary>
        /// ID of the EVSE (Electric Vehicle Supply Equipment)
        /// </summary>
        [Required, Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        /// <summary>
        ///  ID of a specific connector within the EVSE
        /// </summary>

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }
    }
}

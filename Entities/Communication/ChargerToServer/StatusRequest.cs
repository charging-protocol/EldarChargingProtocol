using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class StatusRequest : SocketRequest
    {
        [StringLength(100)]
        public string? ServerTransactionId { get; set; }

        [StringLength(100)]
        public string? ChargerTransactionId { get; set; }

        [Required, MinLength(1)]
        public List<EvseStatus> Evses { get; set; }
    }

    public class EvseStatus
    {
        /// <summary>
        /// ID of the EVSE (Electric Vehicle Supply Equipment)
        /// </summary>
        [Required, Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        /// <summary>
        /// Optional ID of a specific connector within the EVSE
        /// If null, the status applies to the entire EVSE
        //  If greater than 0, the status applies only to the specified connector
        /// </summary>

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }

        /// <summary>
        /// Status of the EVSE or connector
        /// </summary>
        [Required, Range(1, byte.MaxValue)]
        public EvseConnectorStatusEnum? Status { get; set; }

        [Required, Range(1, byte.MaxValue)]
        public EvseConnectorStatusEnum? OldStatus { get; set; }

        public Dictionary<string, object>? Data { get; set; }

    }

    public enum EvseConnectorStatusEnum : byte
    {
        Available,
        Unavailable,
        Faulted,
        Occupied,

        //evse only
        Charging,
        SuspendedEV,
        SuspendedEVSE,
        Reserved,
        Preparing,
        Finishing,
        Idle,
        EVConnected,
    }

}

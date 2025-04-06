using System.ComponentModel.DataAnnotations;

namespace Entities.App.Chargers
{
    public class UpdateChargersStatusRequest
    {
        [Required, MinLength(1)]
        public List<ChargerStatus> Chargers { get; set; }
    }

    public class ChargerStatus
    {
        [Required, StringLength(100)]
        public string ChargerId { get; set; }

        [Required, MinLength(1)]
        public List<EvseStatus> Evses { get; set; }

        public Dictionary<string, object>? Extend { get; set; }
    }



    public class EvseStatus
    {
        [StringLength(100)]
        public string EvseId { get; set; }

        [StringLength(100)]
        public string? ConnectorId { get; set; }

        [Required]
        public EvseConnectorStatusEnum? Status { get; set; }

        public EvseConnectorStatusEnum? OldStatus { get; set; }

        public Dictionary<string, object>? Extend { get; set; }

    }

    public enum EvseConnectorStatusEnum : byte
    {
        Available,
        Unavailable,
        Faulted,
        Occupied,
        Unknown,

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

using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.Common
{
    public class SocketRequest
    {
        [Required]
        public CommandEnum? Command { get; set; }

        [Required]
        public bool? IsResponse { get; set; } = false;

        [Required]
        public string ReqId { get; set; }

        [Required]
        public DateTime? DateTime { get; set; }

        [MinLength(1)]
        public Dictionary<string, object>? Data { get; set; }
    }



    public enum CommandEnum
    {
        // -------- From Charger to Server --------
        Connect,
        Boot,
        Authorize,
        Heartbeat,
        Meter,
        Start,
        Stop,
        Status,
        SupportedParameters,

        SendParameters,
        GetParameters,

        SendTokens,
        GetTokens,

        Event,

        // -------- From Server to Charger --------
        SendChargingProfile,
        DeleteChargingProfile,

        Reserve,
        UnReserve,

        RemoteStart,
        RemoteStop,

        UpdateFirmware,
        CancelUpdateFirmware,

        UnlockConnector,
        UpdateCost,
        Trigger,
        Reset,
        Availability,
        DeleteCache,
        GetTransactionStatus,
        GetLogs
    }



}

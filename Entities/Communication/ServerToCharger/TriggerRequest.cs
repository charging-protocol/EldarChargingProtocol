using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class TriggerRequest : SocketRequest
    {
        [Required]
        public TriggerEnum? Trigger { get; set; }
    }

    public enum TriggerEnum : byte
    {
        Boot,
        Heartbeat,
        Meter,
        Status,
        SupportedParameters,
        UploadLogsStatus,
        FirmwareDetails,
        FirmwareUpdateDetails,
    }




}

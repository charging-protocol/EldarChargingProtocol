using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class BootRequest : SocketRequest
    {
        [Required]
        public BootReasonEnum? Reason { get; set; }

        [Required, StringLength(200)]
        public string ManufacturerName { get; set; }

        [Required, StringLength(200)]
        public string Model { get; set; }

        [Required, StringLength(300)]
        public string SerialNumber { get; set; }

        [Required, StringLength(300)]
        public string FirmwareVersion { get; set; }

        [StringLength(100)]
        public string? Iccid { get; set; }

        [StringLength(100)]
        public string? Imsi { get; set; }
    }


    public enum BootReasonEnum : byte
    {
        PowerUp,
        RemoteReset,
        Reset,
        ScheduledReset,
        FirmwareUpdate,
        Unknown,
    }


}

using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class DeleteChargingProfileRequest : SocketRequest
    {
        [StringLength(100)]
        public string? ProfileId { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        public bool? DeleteAll { get; set; }
    }
}
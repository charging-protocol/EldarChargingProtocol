using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class AvailabilityRequest : SocketRequest
    {
        [Required]
        public AvailabilityEnum? Availability { get; set; }

        /// <summary>
        /// ID of the EVSE (Electric Vehicle Supply Equipment)
        /// </summary>
        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }

    }

    public enum AvailabilityEnum : byte
    {
        On,
        Off,
    }


}
using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class ResetRequest : SocketRequest
    {
        public ResetEnum? Type { get; set; }

        /// <summary>
        /// ID of the EVSE (Electric Vehicle Supply Equipment)
        /// </summary>
        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }
    }

    public enum ResetEnum : byte
    {
        Immediate,
        OnIdle
    }

}

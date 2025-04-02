using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class UnlockConnectorRequest : SocketRequest
    {
        /// <summary>
        /// ID of the EVSE (Electric Vehicle Supply Equipment)
        /// </summary>
        [Required, Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }
    }



}

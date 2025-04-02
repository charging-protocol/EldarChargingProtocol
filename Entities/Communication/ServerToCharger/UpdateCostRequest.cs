using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class UpdateCostRequest : SocketRequest
    {

        [StringLength(100)]
        public string? TransactionId { get; set; }

        /// <summary>
        /// ID of the EVSE (Electric Vehicle Supply Equipment)
        /// </summary>
        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }


        [Required, Range(0, double.MaxValue)]
        public decimal? Cost { get; set; }

    }



}
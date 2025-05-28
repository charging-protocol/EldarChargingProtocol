using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class AuthorizeRequest : SocketRequest
    {
        [Required]
        public AuthorizeActionEnum? Action { get; set; }

        [Required]
        public TokenTypeEnum? TokenType { get; set; }

        [StringLength(3000)]
        public string? Token { get; set; }

        [StringLength(100)]
        public string? ServerTransactionId { get; set; }

        [Required, StringLength(100)]
        public string ChargerTransactionId { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int? RunningNumber { get; set; }


        /// <summary>
        /// ID of the EVSE (Electric Vehicle Supply Equipment)
        /// </summary>
        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        /// <summary>
        /// Optional ID of a specific connector within the EVSE
        /// </summary>

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }


        [StringLength(50)]
        public string? PayProfile { get; set; }
    }

    public enum AuthorizeActionEnum : byte
    {
        Auth,
        Cancel
    }

}

using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class ReserveRequest : SocketRequest
    {
        public bool SkipAuthorize { get; set; } = false;

        /// <summary>
        /// Id of reservation. //UUID
        /// If ServerTransactionId not exists in charger its new reservation, otherwise its update of existing reservation, if empty reserve.
        /// </summary>
        [StringLength(100)]
        public string ServerTransactionId { get; set; }

        /// <summary>
        /// EvseId to be reserved.
        /// </summary>
        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        [Required]
        public DateTime? ExpiryDate { get; set; }

        [Required]
        public TokenTypeEnum? TokenType { get; set; }

        [StringLength(3000)]
        public string? Token { get; set; }

        [StringLength(100)]
        public string? TokenGroupId { get; set; }
    }



}

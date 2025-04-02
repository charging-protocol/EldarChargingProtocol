using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class RemoteStartRequest : SocketRequest
    {
        public bool SkipAuthorize { get; set; } = false;

        [StringLength(100)]
        public string? ServerTransactionId { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        [Required]
        public TokenTypeEnum? TokenType { get; set; }

        [StringLength(3000)]
        public string? Token { get; set; }

        [StringLength(100)]
        public string? TokenGroupId { get; set; }

        public ChargingProfile? Profile { get; set; }
    }



}

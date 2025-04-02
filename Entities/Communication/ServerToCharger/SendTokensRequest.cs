using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class SendTokensRequest : SocketRequest
    {
        [Required]
        public SendTypeEnum? Type { get; set; }

        public List<SendToken> Tokens { get; set; }

        public DateTime? CacheExpiryDate { get; set; }
    }

    public enum SendTypeEnum : byte
    {
        New,
        Update
    }

    public class SendToken
    {
        [StringLength(100)]
        public string? TokenId { get; set; }

        [Required]
        public TokenTypeEnum? TokenType { get; set; }

        [Required, StringLength(2000)]
        public string? Token { get; set; }

        [StringLength(100)]
        public string? TokenGroupId { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [MinLength(1)]
        public List<int>? EvseIds { get; set; }
    }

}
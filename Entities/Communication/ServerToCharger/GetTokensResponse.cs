using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class GetTokensResponse : SocketResponse
    {
        public List<GetToken> Tokens { get; set; }
    }

    public class GetToken
    {
        [StringLength(100)]
        public string? TokenId { get; set; }

        [Required]
        public TokenTypeEnum? TokenType { get; set; }

        [StringLength(100)]
        public string? TokenGroupId { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [MinLength(1)]
        public List<int>? EvseIds { get; set; }
    }

    public enum GetTokensCodeEnum : byte
    {
        Ok,
        Rejected,
        NotFound
    }


}
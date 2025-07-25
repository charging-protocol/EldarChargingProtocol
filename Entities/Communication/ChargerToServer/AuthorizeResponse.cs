using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class AuthorizeResponse : SocketResponse
    {
        [StringLength(100)]
        public string? TokenGroupId { get; set; }
        public DateTime? TokenExpiryDate { get; set; }

        public long? LimitWh { get; set; }
        public long? LimitChargeTimeSeconds { get; set; }

        public bool? DontCacheCard { get; set; }
    }

    public enum AuthorizeCodeEnum : byte
    {
        Ok,
        Rejected,
    }

}

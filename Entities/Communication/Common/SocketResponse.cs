using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.Common
{
    public class SocketResponse
    {
        [Required]
        public bool IsResponse { get; set; } = true;

        [Required]
        public string ReqId { get; set; } // UUID

        [Required]
        public bool? IsError { get; set; } = false;

        [Required]
        public ResponseCodeEnum? Code { get; set; } = ResponseCodeEnum.Ok;

        [MinLength(1)]
        public List<Language>? Message { get; set; }

        [Required]
        public DateTime? DateTime { get; set; }

        [MinLength(1)]
        public Dictionary<string, object>? Data { get; set; }
    }


    public enum ResponseCodeEnum : byte
    {
        Ok,
        Rejected,
        Blocked,
        Expired,
        Invalid,
        Failed,
        Error
    }

    public class Language
    {
        [StringLength(10)]
        public string Lang { get; set; }

        [StringLength(1000)]
        public string Msg { get; set; }
    }


}


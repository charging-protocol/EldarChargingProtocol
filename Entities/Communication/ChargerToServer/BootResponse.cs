using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class BootResponse : SocketResponse
    {

        [Required]
        public DateTime? TimeStamp { get; set; }

        [Required]
        public int? BootInterval { get; set; }
    }

    public enum BootCodeEnum : byte
    {
        Ok,
        Rejected,
    }

}

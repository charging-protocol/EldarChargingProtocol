using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class StopResponse : SocketResponse
    {
        [Range(0, double.MaxValue)]
        public double? TotalCost { get; set; }
    }

    public enum StopCodeEnum : byte
    {
        Ok,
        Rejected,
    }
}

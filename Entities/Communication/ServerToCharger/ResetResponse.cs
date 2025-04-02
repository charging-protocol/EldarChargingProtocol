using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class ResetResponse : SocketResponse
    {

    }


    public enum ResetCodeEnum : byte
    {
        Ok,
        Rejected,
        Scheduled,
    }
}

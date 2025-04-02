using Entities.Communication.Common;

namespace Entities.Communication.ChargerToServer
{
    public class HeartbeatResponse : SocketResponse
    {

    }
    public enum HeartbeatCodeEnum : byte
    {
        Ok,
        Rejected,
    }

}



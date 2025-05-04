using Entities.Communication.Common;

namespace Entities.Communication.ChargerToServer
{
    public class StatusResponse : SocketResponse
    {
    }

    public enum StatusCodeEnum : byte
    {
        Ok,
        Rejected,
    }
}

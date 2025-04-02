using Entities.Communication.Common;

namespace Entities.Communication.ChargerToServer
{
    public class StatusResponse : SocketResponse
    {
    }

    public enum AEvsesStatusCodeEnum : byte
    {
        Ok,
        Rejected,
    }
}

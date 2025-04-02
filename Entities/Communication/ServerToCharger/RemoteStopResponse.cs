using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class RemoteStopResponse : SocketResponse
    {

    }

    public enum RemoteStopCodeEnum : byte
    {
        Ok,
        Rejected,
    }


}

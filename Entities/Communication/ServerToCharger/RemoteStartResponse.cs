using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class RemoteStartResponse : SocketResponse
    {

    }

    public enum RemoteStartCodeEnum : byte
    {
        Ok,
        Rejected,
    }


}

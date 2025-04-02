using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class ReserveResponse : SocketResponse
    {

    }

    public enum ReserveCodeEnum : byte
    {
        Faulted,

        Occupied,

        Unavailable
    }


}

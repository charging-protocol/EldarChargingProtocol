using Entities.Communication.Common;

namespace Entities.Communication.ChargerToServer
{
    public class MeterResponse : SocketResponse
    {

    }

    public enum MeterCodeEnum : byte
    {
        Ok,
        Rejected,
    }
}


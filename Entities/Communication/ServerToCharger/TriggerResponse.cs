using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class TriggerResponse : SocketResponse
    {


    }

    public enum TriggerCodeEnum : byte
    {
        Ok,
        Rejected,
        NotSupported,
    }


}

using Entities.Communication.Common;

namespace Entities.Communication.ChargerToServer
{
    public class SupportedParametersResponse : SocketResponse
    {

    }

    public enum SupportedParametersCodeEnum : byte
    {
        Ok,
        Rejected,
    }

}

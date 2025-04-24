using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class ObserveParametersResponse : SocketResponse
    {

    }

    public enum ObserveParameterCodeEnum : byte
    {
        Ok,
        Rejected,
    }



}
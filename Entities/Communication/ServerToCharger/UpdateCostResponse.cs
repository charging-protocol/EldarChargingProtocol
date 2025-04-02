using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class UpdateCostResponse : SocketResponse
    {

    }

    public enum UpdateCostCodeEnum : byte
    {
        Ok,
        NotFound,
    }



}
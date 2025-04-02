using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class DeleteChargingProfileResponse : SocketResponse
    {

    }
    public enum DeleteChargingProfileCodeEnum : byte
    {
        Ok,
        NotFound,
    }

}
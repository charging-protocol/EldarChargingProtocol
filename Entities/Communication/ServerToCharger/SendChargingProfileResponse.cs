using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{

    public class SendChargingProfileResponse : SocketResponse
    {

    }

    public enum ChargingProfileCodeEnum : byte
    {
        Accepted,
        Rejected,
    }



}
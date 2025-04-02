using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class AvailabilityResponse : SocketResponse
    {

    }

    public enum AvailabilityCodeEnum : byte
    {
        Ok,
        Rejected,
        Scheduled,
    }


}
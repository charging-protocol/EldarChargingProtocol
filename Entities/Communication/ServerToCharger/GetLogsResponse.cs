using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class GetLogsResponse : SocketResponse
    {

    }

    public enum UploadLogsCodeEnum : byte
    {
        Ok,
        Rejected,
        Scheduled,
    }


}
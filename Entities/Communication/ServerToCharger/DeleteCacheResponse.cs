using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class DeleteCacheResponse : SocketResponse
    {

    }

    public enum DeleteCacheCodeEnum : byte
    {
        Ok,
        Rejected,
    }

}
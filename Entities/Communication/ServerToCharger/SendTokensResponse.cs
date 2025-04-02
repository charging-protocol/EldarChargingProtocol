using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class SendTokensResponse : SocketResponse
    {

    }

    public enum SendTokensCodeEnum : byte
    {
        Ok,
        Rejected
    }


}
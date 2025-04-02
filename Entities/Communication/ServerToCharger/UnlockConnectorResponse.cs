using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class UnlockConnectorResponse : SocketResponse
    {

    }


    public enum UnlockCodeEnum : byte
    {
        Ok,
        Failed,
        ActiveTransaction,
        UnknownConnector,
    }
}

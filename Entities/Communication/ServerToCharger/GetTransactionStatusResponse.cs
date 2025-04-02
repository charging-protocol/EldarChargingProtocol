using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class GetTransactionStatusResponse : SocketResponse
    {

    }

    public enum TransactionStatusCodeEnum : byte
    {
        None,
        Active,
    }



}
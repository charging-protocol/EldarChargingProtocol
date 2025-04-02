using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class UnReserveResponse : SocketResponse
    {

    }

    public enum UnReserveCodeEnum : byte
    {
        Ok ,
        Rejected ,
    }


}

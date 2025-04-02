using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{

    public class CancelUpdateFirmwareResponse : SocketResponse
    {

    }


    public enum CancelUpdateFirmwareCodeEnum : byte
    {
        Ok,
        Rejected,
        AlreadyInstalling
    }

}
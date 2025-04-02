using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{

    public class UpdateFirmwareResponse : SocketResponse
    {

    }


    public enum UpdateFirmwareCodeEnum : byte
    {
        Ok,
        Rejected,
        AlreadyInstalling,
        Downloading
    }

}
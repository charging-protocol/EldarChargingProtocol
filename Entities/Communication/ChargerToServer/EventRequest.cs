using Entities.Communication.Common;

namespace Entities.Communication.ChargerToServer
{
    public class EventRequest : SocketRequest
    {
        public EventType EventType { get; set; }
    }

    public enum EventType
    {
        UploadLogsStatus,
        FirmwareUpdateDetails,
        FirmwareDetails
    }


    public enum UploadLogsStatusCodeEnum : byte
    {
        Uploaded,
        Uploading,
        PermissionDenied,
        UploadingFailed
    }


    public enum FirmwareUpdateDetailsCodeEnum : byte
    {
        WaitingForTransactionToEnd,
        Downloading,
        Downloaded,
        DownloadFailed,
        Installing,
        Installed,
        InstallationFailed
    }

}

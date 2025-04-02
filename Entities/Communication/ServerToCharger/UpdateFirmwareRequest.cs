using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class UpdateFirmwareRequest : SocketRequest
    {

        [Range(0, int.MaxValue)]
        public byte? Retries { get; set; }

        [Range(0, int.MaxValue)]
        public int? RetryInterval { get; set; }

        [Required, StringLength(100)]
        public string? RequestId { get; set; }

        [Required, Url, StringLength(1000)]
        public string Url { get; set; }

        public DateTime? DownloadDateTime { get; set; }

        public DateTime? InstallDateTime { get; set; }


    }



}
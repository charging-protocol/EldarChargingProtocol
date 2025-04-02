using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class CancelUpdateFirmwareRequest : SocketRequest
    {
        [Required, StringLength(100)]
        public string? RequestId { get; set; }
    }



}
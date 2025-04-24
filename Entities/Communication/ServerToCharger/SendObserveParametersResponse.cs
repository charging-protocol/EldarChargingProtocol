using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class SendObserveParametersResponse : SocketResponse
    {
        [MinLength(1)]
        public List<SendObserveParameterResponse>? Parameters { get; set; }
    }

    public class SendObserveParameterResponse
    {
        public Dictionary<string, object>? Extend { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }

        [Required]
        public SendObserveParameterCodeEnum? Code { get; set; }
    }

    public enum SendObserveParameterCodeEnum : byte
    {
        Ok,
        Rejected,
        Unknown,
    }



}
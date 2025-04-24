using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class DeleteObserveParametersResponse : SocketResponse
    {
        [MinLength(1)]
        public List<DeleteObserveParameterResponse>? Parameters { get; set; }
    }

    public class DeleteObserveParameterResponse
    {
        public Dictionary<string, object>? Extend { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }

        [Required]
        public DeleteObserveParameterCodeEnum? Code { get; set; }
    }

    public enum DeleteObserveParameterCodeEnum : byte
    {
        Ok,
        Rejected,
        Unknown,
    }



}
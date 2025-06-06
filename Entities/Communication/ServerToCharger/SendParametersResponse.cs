using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class SendParametersResponse : SocketResponse
    {
        [Required, MinLength(1)]
        public List<ParameterResponse> Parameters { get; set; }
    }

    public class ParameterResponse
    {
        public Dictionary<string, object>? Extend { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }


        [Required]
        public SendParameterCodeEnum? Code { get; set; }
    }

    public enum SendParameterCodeEnum : byte
    {
        Ok,
        Rejected,
        Unknown,
        RebootRequired,
    }




}
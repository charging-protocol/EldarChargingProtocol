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
        public Dictionary<string, object>? Data { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

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
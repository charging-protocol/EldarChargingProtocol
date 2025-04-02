using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class GetParametersResponse : SocketResponse
    {
        [Required]
        public List<GetParameterResponseItem> Parameters { get; set; }
    }


    public class GetParameterResponseItem
    {
        public Dictionary<string, object>? Data { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string? Val { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }

        [Required]
        public GetParameterStatusEnum? Status { get; set; }
    }


    public enum GetParameterStatusEnum : byte
    {
        Ok,
        Unknown,
        NotAllowToRead
    }




}
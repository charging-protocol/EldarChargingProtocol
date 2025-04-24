using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class SendObserveParametersRequest : SocketRequest
    {

        [Required, MinLength(1)]
        public List<SendObserveParameter> Parameters { get; set; }
    }


    public class SendObserveParameter
    {
        public Dictionary<string, object>? Extend { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }

        [Required, Range(1, 5)]
        public ObserveTypeEnum? Type { get; set; }

        [StringLength(5000)]
        public string Value { get; set; }
        public ObserveAlertEnum Alert { get; set; }
    }

    public enum ObserveTypeEnum : byte
    {
        Changed,
        Up,
        Down,
        MeterInterval,
        MeterTransaction

    }


}
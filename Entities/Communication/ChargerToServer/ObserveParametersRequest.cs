using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class ObserveParametersRequest : SocketRequest
    {
        [Required]
        public DateTime TimeStamp { get; set; }

        [Required, MinLength(1)]
        public List<ObserveParameter> Parameters { get; set; }

        [StringLength(100)]
        public string? ServerTransactionId { get; set; }

        [StringLength(100)]
        public string? ClientTransactionId { get; set; }
    }


    public class ObserveParameter
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

        [Required, StringLength(5000)]
        public string Value { get; set; }

        public ObserveAlertEnum Alert { get; set; }

    }


    public enum ObserveAlertEnum
    {
        Info,
        Debug,
        Warning,
        Critical,
        Emergency
    }

}
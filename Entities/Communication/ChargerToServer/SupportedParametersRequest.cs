using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class SupportedParametersRequest : SocketRequest
    {
        [MinLength(1)]
        public List<SupportedParameter>? Parameters { get; set; }
    }

    public class SupportedParameter
    {
        public Dictionary<string, object>? Data { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string? Val { get; set; }
        public bool? IsEvse { get; set; }
        public bool? IsConnector { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsWrite { get; set; }
        public bool? OrderMatter { get; set; }

        [StringLength(1000)]
        public string? PossibleValues { get; set; }

        [StringLength(1000)]
        public string? RecommendedValues { get; set; }
        public decimal? Min { get; set; }
        public decimal? Max { get; set; }
        public UnitEnum? Unit { get; set; }
    }

    public enum ParameterTypeEnum : byte
    {
        Integer,
        Decimal,
        String,
        Boolean,
        DateTime,
        Date,
        Time,
        Guid,
        Object,
        StringArray,
        IntegerArray,
        DecimalArray,
        ObjectArray
    }


}

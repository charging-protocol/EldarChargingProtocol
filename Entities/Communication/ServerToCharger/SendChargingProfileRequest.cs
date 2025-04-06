using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class SendChargingProfileRequest : SocketRequest
    {
        /// <summary>
        /// ID of the EVSE (Electric Vehicle Supply Equipment)
        /// </summary>
        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        [Required]
        public ChargingProfile Profile { get; set; }
    }
    public class ChargingProfile
    {
        [Required, StringLength(100)]
        public string ProfileId { get; set; }

        [Required, Range(0, byte.MaxValue)]
        public byte? Priority { get; set; } = 0;  // higher override lower

        [Required]
        public ProfileTypeEnum? ProfileTypeEnum { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        [StringLength(100)]
        public string? TransactionId { get; set; }

        [Required, MinLength(1)]
        public List<Period> Periods { get; set; }
    }
    public enum ProfileTypeEnum : byte
    {
        Default,
        SpecificTransaction,
        AllStationMaxValue,
    }

    public class Period
    {
        public Dictionary<string, object>? Extend { get; set; }

        [StringLength(5)]
        public string? StartDate { get; set; } // MM-dd
        public TimeOnly? StartTime { get; set; }

        [StringLength(5)]
        public string? StopDate { get; set; } // MM-dd
        public TimeOnly? StopTime { get; set; }

        public List<DayOfWeekEnum>? Days { get; set; }

        [Required, Range(0, double.MaxValue)]
        public double? Val { get; set; }
    }

    public enum DayOfWeekEnum : byte
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }





}
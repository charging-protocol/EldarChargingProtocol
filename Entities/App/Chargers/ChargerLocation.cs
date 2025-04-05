using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.App.Chargers
{
    public class ChargerLocation
    {
        public Company? OwnerDetails { get; set; }

        public double? Latitude { get; set; } // Required if LocationId is null
        public double? Longitude { get; set; } // Required if LocationId is null

        public float? TimeZone { get; set; } // Required if LocationId is null

        [StringLength(200)]
        public string? Address { get; set; }  // Required if LocationId is null

        [StringLength(200)]
        public string? City { get; set; }  // Required if LocationId is null

        [StringLength(200)]
        public string? State { get; set; }

        [StringLength(200)]
        public string? Country { get; set; }  // Required if LocationId is null

        [StringLength(200)]
        public string? PostalCode { get; set; }

        public List<DayHour>? OpeningHours { get; set; }

        public List<Language>? Notes { get; set; }

        public List<string>? Images { get; set; }


        [Required]
        public DateTime? Updated { get; set; }
    }

}

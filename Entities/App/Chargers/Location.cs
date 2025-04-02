using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.App.Chargers
{
    public class Location
    {
        [StringLength(100)]
        public string LocationId { get; set; }

        [Required, StringLength(500)]
        public string LocationName { get; set; }


        [Required, StringLength(100)]
        public string CpoId { get; set; }

        [Required]
        public float? TimeZone { get; set; }


        [Required, StringLength(200)]
        public string Address { get; set; }

        [Required, StringLength(200)]
        public string City { get; set; }

        [StringLength(200)]
        public string State { get; set; }

        [Required, StringLength(200)]
        public string Country { get; set; }

        [StringLength(200)]
        public string PostalCode { get; set; }


        [Required, StringLength(100)]
        public string Latitude { get; set; }

        [Required, StringLength(100)]
        public string Longitude { get; set; }

        public List<DayHour>? OpeningHours { get; set; }

        public List<Language>? Notes { get; set; }

        public List<string>? Images { get; set; }


        [Required]
        public DateTime? Updated { get; set; }


    }


    public class DayHour
    {
        [Required, Range(1, 7)]
        public byte Weekday { get; set; }
        public TimeOnly? Start { get; set; }
        public TimeOnly? Stop { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Entities.App.Transactions
{
    public class Tariff
    {
        [Required, StringLength(100)]
        public string Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(100)]
        public string CpoId { get; set; }

        [Required, StringLength(3)]
        public string Currency { get; set; }
        public double? Vat { get; set; }
        public DateTime? ValidFromDate { get; set; }

        public DateTime? ValidToDate { get; set; }

        public string? DetailsUrl { get; set; }

        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }

        [Required, MinLength(1)]
        public List<TariffPeriod> Periods { get; set; }


        [Required]
        public DateTime? Created { get; set; }

        [Required]
        public DateTime? Updated { get; set; }
    }


    public class TariffPeriod
    {
        [Required]
        public List<PriceItem> Prices { get; set; }

        public TimeSpan? StartTime { get; set; }  // inclusive

        public TimeSpan? EndTime { get; set; } // exclusive

        public DateOnly? StartDate { get; set; } // inclusive

        public DateOnly? EndDate { get; set; } // exclusive

        public List<byte>? Days { get; set; }

        public double? MinKwh { get; set; } // inclusive

        public double? MaxKwh { get; set; } // exclusive

        public double? MinCurrent { get; set; }

        public double? MaxCurrent { get; set; }

        public double? MinPower { get; set; }

        public double? MaxPower { get; set; }

        public int? MinDuration { get; set; } // inclusive

        public int? MaxDuration { get; set; } // exclusive

    }

    public class PriceItem
    {
        [Required]
        public TariffTypeEnum? Type { get; set; }

        [Required]
        public double? Price { get; set; }

        public double? Vat { get; set; }

        [Required]
        public int? Step { get; set; }

    }
}

using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.App.Transactions
{
    public class Invoice
    {
        [Required, StringLength(100)]
        public string Id { get; set; }

        [Required, StringLength(100)]
        public string TransactionId { get; set; }

        [Required, StringLength(100)]
        public string CpoId { get; set; }

        [Required, StringLength(100)]
        public string LocationId { get; set; }

        [Required, StringLength(500)]
        public string LocationName { get; set; }

        [Required]
        public float? TimeZone { get; set; }


        [Required, StringLength(200)]
        public string LocationAddress { get; set; }

        [Required, StringLength(200)]
        public string LocationCity { get; set; }

        [StringLength(200)]
        public string? LocationState { get; set; }

        [Required, StringLength(200)]
        public string LocationCountry { get; set; }

        [StringLength(200)]
        public string LocationPostalCode { get; set; }

        [Required]
        public double? Latitude { get; set; }

        [Required]
        public double? Longitude { get; set; }

        [Required, StringLength(100)]
        public string ChargerId { get; set; }

        [Required, StringLength(100)]
        public string EvseId { get; set; }

        [StringLength(100)]
        public string ConnectorId { get; set; }

        [Required]
        public DateTime? Start { get; set; }

        [Required]
        public DateTime? Stop { get; set; }



        [StringLength(3)]
        public string? Currency { get; set; }


        [Required]
        public TokenTypeEnum? TokenType { get; set; }

        [StringLength(3000)]
        public string? Token { get; set; }

        [StringLength(100)]
        public string TokenCpoId { get; set; }

        public List<Tariff>? Tariffs { get; set; }

        public List<ChargePeriod>? Periods { get; set; }

        public List<TotalPeriod>? TotalPeriods { get; set; }


        [Required]
        public double? Cost { get; set; }

        public double? CostWithoutVat { get; set; }



        [Required]
        public DateTime? Created { get; set; }
    }



    public class TotalPeriod
    {
        [Required]
        public TariffTypeEnum? Type { get; set; }

        [Required]
        public double? Amount { get; set; }

        [Required]
        public double? Cost { get; set; }

        public double? CostWithoutVat { get; set; }
    }

    public class ChargePeriod
    {
        [StringLength(100)]
        public string TariffId { get; set; }

        [Required]
        public DateTime? Start { get; set; }

        [Required, MinLength(1)]
        public List<PeriodItem> Periods { get; set; }

    }
    public class PeriodItem
    {
        [Required]
        public TariffTypeEnum? Type { get; set; }

        [Required]
        public double? Amount { get; set; }
    }

    public enum TariffTypeEnum : byte
    {
        Energy = 1,
        OneTimeFee = 2,
        ParkingTime = 3,
        ChargingTime = 4,
        ReservationTime = 5,
        ReservationExpireTime = 6,
    }
}

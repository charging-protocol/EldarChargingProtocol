using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.App.Transactions
{
    public class Transaction
    {
        [Required, StringLength(100)]
        public string Id { get; set; }


        [Required, StringLength(100)]
        public string CpoId { get; set; }

        [Required, StringLength(100)]
        public string LocationId { get; set; }

        [Required, StringLength(100)]
        public string ChargerId { get; set; }

        [Required, StringLength(100)]
        public string EvseId { get; set; }

        [StringLength(100)]
        public string ConnectorId { get; set; }


        public DateTime? Start { get; set; }

        public DateTime? Stop { get; set; }

        public DateTime? ReservationStart { get; set; }

        public DateTime? ReservationStop { get; set; }


        public int? Kwh { get; set; }

        [StringLength(3)]
        public string? Currency { get; set; }

        public double? Cost { get; set; }

        public double? CostWithoutVat { get; set; }

        [Required]
        public TokenTypeEnum? TokenType { get; set; }

        [StringLength(3000)]
        public string? Token { get; set; }

        [StringLength(100)]
        public string TokenCpoId { get; set; }



        [Required]
        public DateTime? Updated { get; set; }

        [Required]
        public DateTime? Created { get; set; }
    }
}

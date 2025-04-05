using System.ComponentModel.DataAnnotations;

namespace Entities.App.Chargers
{
    public class Charger
    {
        [Required, StringLength(100)]
        public string Id { get; set; }

        [StringLength(100)]
        public string? CpoId { get; set; } // Required if LocationId is null

        public Company? Company { get; set; }

        [StringLength(100)]
        public string? LocationId { get; set; }

        public ChargerLocation? ChargerLocation { get; set; }  // Required if LocationId is null

        public List<PaymentSupportEnum>? PaymentSupport { get; set; }

        //[StringLength(100)]
        public List<string>? TariffsIds { get; set; }

        [Required, MinLength(1)]
        public List<EVSE> EVSES { get; set; }

        [StringLength(500)]
        public string? TermsUrl { get; set; }

        [Required]
        public DateTime? Updated { get; set; }
    }

    public enum PaymentSupportEnum : byte
    {
        App,
        CreditCard,
        RFID,
        Cash
    }

}

using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.App.Chargers
{
    public class Charger
    {

        [Required, StringLength(100)]
        public string ChargerId { get; set; }


        [StringLength(100)]
        public string LocationId { get; set; }

        public Location? Location { get; set; }

        public List<PaymentSupportEnum>? PaymentSupport { get; set; }

        public List<Language>? Notes { get; set; }


        [StringLength(100)]
        public string Latitude { get; set; }

        [StringLength(100)]
        public string Longitude { get; set; }

        public List<string>? Images { get; set; }


        [StringLength(100)]
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

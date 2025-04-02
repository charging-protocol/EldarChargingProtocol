using System.ComponentModel.DataAnnotations;

namespace Entities.App.Actions
{
    public class UnReserveRequest : ActionRequest
    {
        [Required, StringLength(100)]
        public string? TransactionId { get; set; }

        [Required, StringLength(100)]
        public string? ChargerId { get; set; }

        [Required, StringLength(100)]
        public string? EVSEId { get; set; }

    }
}

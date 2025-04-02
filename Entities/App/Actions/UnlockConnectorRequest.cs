using System.ComponentModel.DataAnnotations;

namespace Entities.App.Actions
{
    public class UnlockConnectorRequest : ActionRequest
    {
        [Required, StringLength(100)]
        public string? TransactionId { get; set; }

        [Required, StringLength(100)]
        public string? ChargerId { get; set; }

        [Required, StringLength(100)]
        public string? EVSEId { get; set; }

        [StringLength(100)]
        public string? ConnectorId { get; set; }
    }
}

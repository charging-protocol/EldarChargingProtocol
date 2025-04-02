using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.App.Actions
{
    public class ReserveRequest : ActionRequest
    {
        [StringLength(100)]
        public string? TransactionId { get; set; } // if exist extend


        [Required, StringLength(100)]
        public string? ChargerId { get; set; }

        [StringLength(100)]
        public string? EVSEId { get; set; }

        [Required]
        public DateTime? ExpiryDate { get; set; }


        [Required]
        public TokenTypeEnum? TokenType { get; set; }

        [StringLength(3000)]
        public string? Token { get; set; }

        [StringLength(100)]
        public string? TokenGroupId { get; set; }


        [StringLength(100)]
        public string? VisualNumber { get; set; }//Visual number/identification printed on the Token

        [StringLength(100)]
        public string? Issuer { get; set; }// The company printed on the token

        bool? NeedToChargeToken { get; set; }


        [StringLength(100)]
        public string? DriverId { get; set; }// Identifies the EV Driver




    }
}

using System.ComponentModel.DataAnnotations;

namespace Entities.App.Chargers
{
    public class Company
    {
        [Required, StringLength(200)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? WebsiteUrl { get; set; }

        [StringLength(500)]
        public string? LogoUrl { get; set; }

        [StringLength(500)]
        public string? TermsUrl { get; set; }
    }
}

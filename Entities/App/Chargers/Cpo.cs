using System.ComponentModel.DataAnnotations;

namespace Entities.App.Chargers
{
    public class Cpo
    {
        [Required, StringLength(100)]
        public string CpoId { get; set; }

        [Required]
        public Company Company { get; set; }
    }
}

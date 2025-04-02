using System.ComponentModel.DataAnnotations;

namespace Entities.App.Actions
{
    public class LateResponse
    {
        [MinLength(1)]
        public Dictionary<string, object>? Data { get; set; }

        [Required]
        public Command? Command { get; set; }
    }
}

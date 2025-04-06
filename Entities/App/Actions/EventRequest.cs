using System.ComponentModel.DataAnnotations;

namespace Entities.App.Actions
{
    public class EventRequest
    {
        [Required]
        public Command? Command { get; set; }

        public object LateResponse { get; set; }
    }
}

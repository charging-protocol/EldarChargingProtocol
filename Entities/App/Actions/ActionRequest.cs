using System.ComponentModel.DataAnnotations;

namespace Entities.App.Actions
{

    public class ActionRequest
    {
        [MinLength(1)]
        public Dictionary<string, object>? Extend { get; set; }

        [Required, StringLength(100)]
        public string ActionId { get; set; }
    }
}

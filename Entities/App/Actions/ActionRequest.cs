using System.ComponentModel.DataAnnotations;

namespace Entities.App.Actions
{

    public class ActionRequest
    {
        [MinLength(1)]
        public Dictionary<string, object>? Data { get; set; }

        [Required, StringLength(100)]
        public string RequestId { get; set; }
    }
}

using Entities.App.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.App.Actions
{

    public class ActionResponse
    {
        [MinLength(1)]
        public Dictionary<string, object>? Data { get; set; }

        [Required]
        public CodeEnum? Code { get; set; }

        [Required, StringLength(100)]
        public string RequestId { get; set; }
    }
}

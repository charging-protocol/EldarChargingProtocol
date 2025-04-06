using Entities.App.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.App.Actions
{

    public class ActionResponse : ApiResponse
    {
        [StringLength(100)]
        public string ActionId { get; set; }


    }
}

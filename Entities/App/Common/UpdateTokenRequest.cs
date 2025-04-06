using System.ComponentModel.DataAnnotations;

namespace Entities.App.Common
{
    public class UpdateTokenRequest
    {
        [Required, StringLength(200)]
        public string NewToken { get; set; }
    }
}

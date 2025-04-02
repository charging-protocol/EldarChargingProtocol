using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class ConnectRequest : SocketRequest
    {

        [Required, StringLength(50)]
        public string Protocol { get; set; }

        [Required, StringLength(100)]
        public string ChargerId { get; set; }

        [Required, StringLength(200, MinimumLength = 10)]
        public string Password { get; set; }

    }
}

using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.App.Chargers
{
    public class EVSE
    {

        [Required, StringLength(100)]
        public string EVSEId { get; set; }

        [Required]
        public EVSEStatusEnum? Status { get; set; }

        public List<Language>? Notes { get; set; }


        //   [StringLength(100)]
        public List<string>? TariffsIds { get; set; }

        [StringLength(100)]
        public List<Connector> Connectors { get; set; }

        [Required]
        public DateTime? Updated { get; set; }
    }


    public enum EVSEStatusEnum : byte
    {
        Available,
        Charging,
        Reserved,
        Unknown,
        Unavailable
    }
}

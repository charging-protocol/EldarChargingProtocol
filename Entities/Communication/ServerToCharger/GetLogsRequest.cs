using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ServerToCharger
{
    public class GetLogsRequest : SocketRequest
    {

        [Required, Url, StringLength(1000)]
        public string Url { get; set; }

        public LogLevel? LogLevel { get; set; }

        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

        [Range(0, int.MaxValue)]
        public byte? Retries { get; set; }

        [Range(0, int.MaxValue)]
        public int? RetryInterval { get; set; }

    }

    public enum LogLevel : byte
    {
        Debug,
        Info,
        Warning,
        Error,
        Fatal
    }

}
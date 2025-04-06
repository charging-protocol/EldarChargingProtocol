using System.ComponentModel.DataAnnotations;

namespace Entities.App.Common
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public bool IsError { get; set; }

        [Required]
        public CodeEnum Code { get; set; }
        public string Message { get; set; }
        public string RequestId { get; set; }
        public string CorrelationId { get; set; }

        [MinLength(1)]
        public Dictionary<string, object>? Extend { get; set; }
    }

    public enum CodeEnum
    {
        Ok,
        Rejected,
        Error,
        LateResponse
    }

    public class ApiResponse
    {
        public bool IsError { get; set; }

        [Required]
        public CodeEnum Code { get; set; }
        public string Message { get; set; }
        public string RequestId { get; set; }
        public string CorrelationId { get; set; }

        [MinLength(1)]
        public Dictionary<string, object>? Extend { get; set; }
    }
}

namespace Entities.App.Common
{
    public class GetRequest
    {
        public int Skip { get; set; }
        public int Take { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}

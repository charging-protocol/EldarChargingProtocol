namespace Entities.App.Common
{
    public class GetRequest
    {
        public int? Skip { get; set; } = 0;
        public int? Take { get; set; } = 100;
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public OrderEnum? Order { get; set; } = OrderEnum.Asc;

    }


    public enum OrderEnum
    {
        Asc, Desc
    }
}

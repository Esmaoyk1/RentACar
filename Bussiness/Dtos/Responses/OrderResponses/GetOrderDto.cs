using Core.Entities;

namespace Bussiness.Dtos.Responses.OrderResponses;

public class GetOrderDto : IDto
{
    public int Id { get; set; }
    public DateTime DeliveryDate { get; set; }
    public DateTime TerceDate { get; set; }
    public decimal TotalPrice { get; set; }
}

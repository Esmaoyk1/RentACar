using Core.Entities;

namespace Bussiness.Dtos.Responses.OrderResponses;

public class GetAllOrderDto : IDto
{
    public string Title {  get; set; }
    public DateTime DeliveryDate { get; set; }
    public DateTime TerceDate { get; set; }
    public TimeSpan Duraction {  get; set; } 
    public int Days { get; set; }
    public decimal TotalPrice { get; set; }

}

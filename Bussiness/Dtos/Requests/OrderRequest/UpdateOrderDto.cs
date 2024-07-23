using Core.Entities;

namespace Bussiness.Dtos.Requests.OrderRequest;

public class UpdateOrderDto : IDto
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public DateTime DeliveryDate { get; set; }
    public DateTime TerceDate { get; set; }
   
}

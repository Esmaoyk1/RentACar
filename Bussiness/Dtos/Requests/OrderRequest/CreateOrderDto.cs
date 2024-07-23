using Core.Entities;
using Entities.Concrete;

namespace Bussiness.Dtos.Requests.OrderRequest;

public class CreateOrderDto : IDto
{
    public int CarId { get; set; }
    public DateTime DeliveryDate { get; set; }
    public DateTime TerceDate { get; set; }
 
}

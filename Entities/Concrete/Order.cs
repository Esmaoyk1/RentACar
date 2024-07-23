using Core.Entities;

namespace Entities.Concrete;

public class Order:Entity
{
    public virtual Car Car { get; set; }
    public int CarId {  get; set; }

    public DateTime DeliveryDate { get; set; }
    public DateTime TerceDate { get; set; }
    public decimal TotalPrice { get; set; }
}

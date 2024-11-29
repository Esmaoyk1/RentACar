using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core.Entities;

public class Entity : IEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool Status { get; set; } = true;
}

//Bu Entity sınıfı, temel özellikleri içeren bir taban sınıf olarak tasarlanmıştır. 
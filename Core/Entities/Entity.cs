namespace Core.Entities;

public class Entity : IEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }  = DateTime.Now;
    public DateTime? DeletedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool Status { get; set; } = true;
}
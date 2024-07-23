using Core.Entities;

namespace Bussiness.Dtos.Responses.ModelResponses;

public sealed class GetAllModelDto : IDto
{
    public int Id {  get; set; }
    public string Name { get; set; }
    public string BrandName { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool Status {  get; set; } = true;
}

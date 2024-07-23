using Core.Entities;

namespace Bussiness.Dtos.Responses.ModelResponses;

public class GetModelDto : IDto
{
    public string Name { get; set; }
    public int BrandId { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool Status {  get; set; }=true;
}

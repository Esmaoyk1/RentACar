using Bussiness.Dtos.Responses.BrandResponses;
using Core.Entities;

namespace Bussiness.Dtos.Models;

public class GetAllBrandModel: IDto
{
    public List<GetAllBrandDto> Items { get; set; }
}

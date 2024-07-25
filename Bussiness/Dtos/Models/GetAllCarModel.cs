using Bussiness.Dtos.Responses.BrandResponses;
using Bussiness.Dtos.Responses.CarResponses;
using Core.Entities;

namespace Bussiness.Dtos.Models;

public class GetAllCarModel:IDto
{
    public List<GetAllCarDto> Items { get; set; }
}

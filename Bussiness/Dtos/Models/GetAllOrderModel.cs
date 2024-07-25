using Bussiness.Dtos.Responses.BrandResponses;
using Bussiness.Dtos.Responses.OrderResponses;
using Core.Entities;

namespace Bussiness.Dtos.Models;

public class GetAllOrderModel:IDto
{
    public List<GetAllOrderDto> Items { get; set; }
}

using Bussiness.Dtos.Responses.ModelResponses;
using Core.Entities;

namespace Bussiness.Dtos.Models;

public class GetAllModelModel : IDto
{
    public List<GetAllModelDto> Items { get; set; }
}


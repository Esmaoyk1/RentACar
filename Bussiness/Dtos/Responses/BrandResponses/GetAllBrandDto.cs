using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Dtos.Responses.BrandResponses;

public sealed class GetAllBrandDto : IDto
{
    public int Id { get; set; }
    public string Name {  get; set; }
    public DateTime CreatedDate { get; set; }
    public bool Status { get; set; } = true;
}

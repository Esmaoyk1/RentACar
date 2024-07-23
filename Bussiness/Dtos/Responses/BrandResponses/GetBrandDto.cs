using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Dtos.Responses.BrandResponses
{
    public class GetBrandDto : IDto
    {
        public string Name {  get; set; }
        public DateTime CreatedTime {  get; set; }
        public bool Status { get; set; } = true;


    }
}

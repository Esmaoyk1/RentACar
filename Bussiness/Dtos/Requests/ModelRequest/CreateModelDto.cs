using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Dtos.Requests.ModelRequest
{
    public class CreateModelDto : IDto
    {
        public string Name {  get; set; }
        public int BrandId { get; set; }

    }
}

﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Dtos.Requests.BrandRequest
{
    public class UpdateBrandDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}

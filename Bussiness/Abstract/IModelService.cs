using Bussiness.Dtos.Requests.BrandRequest;
using Bussiness.Dtos.Requests.ModelRequest;
using Bussiness.Dtos.Responses.BrandResponses;
using Bussiness.Dtos.Responses.ModelResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IModelService
    {
        List<GetAllModelDto> GetAll();
        GetModelDto Get(int id);
        void Add(CreateModelDto createModelDto);
        void Delete(int id);
        void Update(UpdateModelDto updateModelDto);
    }
}

using Bussiness.Dtos.Models;
using Bussiness.Dtos.Requests.BrandRequest;
using Bussiness.Dtos.Requests.ModelRequest;
using Bussiness.Dtos.Responses.BrandResponses;
using Bussiness.Dtos.Responses.ModelResponses;
using Core.Utils.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IModelService
    {
        IDataResult<GetAllModelModel> GetAll();
        IDataResult<GetModelDto> Get(int id);
        
        IResult Add(CreateModelDto createModelDto);
        IResult Delete(int id);
        IResult Update(UpdateModelDto updateModelDto);
    }
}

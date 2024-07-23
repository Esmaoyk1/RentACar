using Bussiness.Dtos.Models;
using Bussiness.Dtos.Requests.BrandRequest;
using Bussiness.Dtos.Responses.BrandResponses;
using Core.Utils.Result;

namespace Bussiness.Abstract
{
    public interface IBrandService
    {
        IDataResult<GetAllBrandModel> GetAll();
        IDataResult<GetBrandDto> Get(int id);
        IResult Add(CreateBrandDto createBrandDto);
        IResult Delete(int id);
        IResult Update(UpdateBrandDto updateBrandDto);
    }
}

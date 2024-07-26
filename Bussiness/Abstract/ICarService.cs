using Bussiness.Dtos.Models;
using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Responses.BrandResponses;
using Bussiness.Dtos.Responses.CarResponses;
using Core.Utils.Result;
using Entities.Concrete;

namespace Bussiness.Abstract;

public interface ICarService
{
    IDataResult<GetAllCarModel> GetAll();
    IDataResult<GetCarDto> Get(int id);
    //List<GetAllCarDto> GetAll();
    //GetCarDto Get(int id);
    IResult Add(CreateCarDto createCarDto);
    IResult Delete(int id);
    IResult Update(UpdateCarDto updateCarDto);
    IDataResult<GetAllCarModel> GetListByRentalStatus();
    IResult UpdateRentalStatus(int carId, RentalStatus newRentalStatus);


    


}

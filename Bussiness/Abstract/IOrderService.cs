using Bussiness.Dtos.Models;
using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Requests.OrderRequest;
using Bussiness.Dtos.Responses.BrandResponses;
using Bussiness.Dtos.Responses.CarResponses;
using Bussiness.Dtos.Responses.OrderResponses;
using Core.Utils.Result;

namespace Bussiness.Abstract;

public interface IOrderService
{

   
    IDataResult<GetAllOrderModel> GetAll();
    IDataResult<GetOrderDto> Get(int id);
    IResult Add(CreateOrderDto createCarDto);
    IResult Delete(int id);
    IResult Update(UpdateOrderDto updateCarDto);

}

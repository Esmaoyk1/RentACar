using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Requests.OrderRequest;
using Bussiness.Dtos.Responses.CarResponses;
using Bussiness.Dtos.Responses.OrderResponses;

namespace Bussiness.Abstract;

public interface IOrderService
{
    List<GetAllOrderDto> GetAll();
    GetOrderDto Get(int id);
    void Add(CreateOrderDto createCarDto);
    void Delete(int id);
    void Update(UpdateOrderDto updateCarDto);

}

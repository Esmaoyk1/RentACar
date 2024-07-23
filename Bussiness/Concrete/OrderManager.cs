using AutoMapper;
using Bussiness.Abstract;
using Bussiness.Dtos.Requests.OrderRequest;
using Bussiness.Dtos.Responses.CarResponses;
using Bussiness.Dtos.Responses.OrderResponses;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Bussiness.Concrete;

public class OrderManager(IOrderRepository _orderRepository, IMapper _mapper, ICarService carService) : IOrderService
{
    public void Add(CreateOrderDto createOrderDto)
    {
        Order order = _mapper.Map<Order>(createOrderDto);
        order.TotalPrice = carService.Get(createOrderDto.CarId).DailyPrice * (createOrderDto.DeliveryDate - createOrderDto.TerceDate).Days;
        _orderRepository.Add(order);
    }

    public void Delete(int id)
    {
        Order order = _orderRepository.Get(x => x.Id == id);
        _orderRepository.Delete(order);
    }

    public GetOrderDto Get(int id)
    {
        Order order = _orderRepository.Get(x => x.Id == id);
        GetOrderDto orderDto = _mapper.Map<GetOrderDto>(order);
       
        return orderDto;

    }

    public List<GetAllOrderDto> GetAll()
    {

        List<Order> orders = _orderRepository.GetAll();
        List<GetAllOrderDto> ordersDto = _mapper.Map<List<GetAllOrderDto>>(orders);
        return ordersDto;
    }

    public void Update(UpdateOrderDto updateOrderDto)
    {
        Order order = _mapper.Map<Order>(updateOrderDto);
        order.TotalPrice = carService.Get(updateOrderDto.CarId).DailyPrice * (updateOrderDto.DeliveryDate - updateOrderDto.TerceDate).Days;
        _orderRepository.Update(order);
    }
}

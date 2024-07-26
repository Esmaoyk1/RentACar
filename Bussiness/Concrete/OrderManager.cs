using AutoMapper;
using Bussiness.Abstract;
using Bussiness.Dtos.Models;
using Bussiness.Dtos.Requests.OrderRequest;
using Bussiness.Dtos.Responses.OrderResponses;
using Core.Utils.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete;

public class OrderManager(IOrderRepository _orderRepository, IMapper _mapper, ICarService carService) : IOrderService
{

    public IResult Add(CreateOrderDto createOrderDto)
    {
        Order order = _mapper.Map<Order>(createOrderDto);
        order.TotalPrice = carService.Get(createOrderDto.CarId).Data.DailyPrice * (createOrderDto.DeliveryDate - createOrderDto.TerceDate).Days;
        order.CreatedDate = DateTime.Now;
        _orderRepository.Add(order);
        carService.UpdateRentalStatus(createOrderDto.CarId, RentalStatus.Leased);
        return new SuccessResult("İşlem Başarıyla Gerçekleşti");
    }

    public IResult Delete(int id)
    {
        Order order = _orderRepository.Get(x => x.Id == id);
        _orderRepository.Delete(order);
        return new SuccessResult("İşlem  başarıyla silindi");
    }

    public IDataResult<GetOrderDto> Get(int id)
    {
        Order order = _orderRepository.Get(x => x.Id == id);
        GetOrderDto result = _mapper.Map<GetOrderDto>(order);
        return new SuccessDataResult<GetOrderDto>(result, "İşem getirildi");
    }

    public IDataResult<GetAllOrderModel> GetAll()
    {
        GetAllOrderModel result = new();
        List<Order> orders = _orderRepository.GetAll();
        List<GetAllOrderDto> temp = _mapper.Map<List<GetAllOrderDto>>(orders);
        result.Items = temp;
        return new SuccessDataResult<GetAllOrderModel>(result, " Listelendi..");
    }

    public IResult Update(UpdateOrderDto updateOrderDto)
    {
        Order order = _orderRepository.Get(x => x.Id == updateOrderDto.Id);
        int oldCarId = order.CarId;
        int newCarId = updateOrderDto.CarId;

        var date = order.CreatedDate;
        order = _mapper.Map<Order>(updateOrderDto);
        order.UpdatedDate = DateTime.Now;
        var car = carService.Get(updateOrderDto.CarId);
        order.TotalPrice = car.Data.DailyPrice * (updateOrderDto.DeliveryDate - updateOrderDto.TerceDate).Days;
        order.CreatedDate = date;
        _orderRepository.Update(order);

        carService.UpdateRentalStatus(oldCarId, RentalStatus.Vacant);
        carService.UpdateRentalStatus(newCarId, RentalStatus.Leased);

        return new SuccessResult("Başarıyla güncellendi");
    }

}

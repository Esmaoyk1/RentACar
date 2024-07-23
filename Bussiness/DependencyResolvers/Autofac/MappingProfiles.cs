using AutoMapper;
using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Requests.ModelRequest;
using Bussiness.Dtos.Requests.OrderRequest;
using Bussiness.Dtos.Responses.CarResponses;
using Bussiness.Dtos.Responses.OrderResponses;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.DependencyResolvers.Autofac;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Car, CreateCarDto>().ReverseMap();

        CreateMap<Car, GetAllCarDto>().ReverseMap();
        CreateMap<Car, GetCarDto>().ReverseMap();
        CreateMap<Car, UpdateCarDto>().ReverseMap();
        CreateMap<Model,UpdateModelDto>().ReverseMap();
        CreateMap<Model, CreateModelDto>().ReverseMap();
        CreateMap<Order,CreateOrderDto>().ReverseMap();
        CreateMap<Order,UpdateOrderDto>().ReverseMap();
        CreateMap<Order,GetOrderDto>().ReverseMap();
        CreateMap<Order,GetAllOrderDto>().ReverseMap();
        
        


          
    }
}

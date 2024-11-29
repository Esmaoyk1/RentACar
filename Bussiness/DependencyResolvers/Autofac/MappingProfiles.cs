using AutoMapper;
using Bussiness.Dtos.Requests.BrandRequest;
using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Requests.ModelRequest;
using Bussiness.Dtos.Requests.OrderRequest;
using Bussiness.Dtos.Responses.BrandResponses;
using Bussiness.Dtos.Responses.CarResponses;
using Bussiness.Dtos.Responses.ModelResponses;
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
    //Profile sınıfı, eşleme yapılandırmalarını içeren bir sınıftır.

    public MappingProfiles()
    {
        CreateMap<Car, CreateCarDto>().ReverseMap();
        CreateMap<Car, GetAllCarDto>().ReverseMap();
        CreateMap<Car, GetCarDto>().ReverseMap();
        CreateMap<Car, UpdateCarDto>().ReverseMap();
       

        CreateMap<Model,UpdateModelDto>().ReverseMap();
        CreateMap<Model, CreateModelDto>().ReverseMap();
        CreateMap<Model, GetAllModelDto>().ReverseMap();
        CreateMap<Model, GetModelDto>().ReverseMap();

        CreateMap<Order,CreateOrderDto>().ReverseMap();
        CreateMap<Order,UpdateOrderDto>().ReverseMap();
        CreateMap<Order,GetOrderDto>().ReverseMap();
        CreateMap<Order,GetAllOrderDto>().ReverseMap();


        CreateMap<Brand, CreateBrandDto>().ReverseMap();
        CreateMap<Brand, UpdateBrandDto>().ReverseMap();
        CreateMap<Brand, GetBrandDto>().ReverseMap();
        CreateMap<Brand, GetAllBrandDto>().ReverseMap();


        AllowNullCollections = true;  //bir koleksiyonun null olmasına izin verir 
        AddGlobalIgnore("Item");    //Item" adında bir özellik varsa, AutoMapper bu özelliği eşleme işlemi sırasında dikkate almaz.


        //Car, Brand, Order, Model gibi entity'lerle ilgili DTO'lar arasında otomatik dönüşümleri tanımlar. Bu dönüşümler, uygulamanın veri ile çalışırken veri formatlarının birbirine dönüştürülmesi işlemini otomatikleştirir, böylece manuel eşlemeyi ortadan kaldırır 
    }
}

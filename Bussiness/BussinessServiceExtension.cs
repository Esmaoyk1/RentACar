using Bussiness.Abstract;
using Bussiness.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Bussiness;

public static class BussinessServiceExtension
{
    public static IServiceCollection AddBussinessServices(this IServiceCollection services)
    {
        services.AddTransient<IBrandService, BrandManager>();
        services.AddTransient<IModelService, ModelManager>();

        services.AddTransient<ICarService, CarManager>();
     
        services.AddTransient<IOrderService, OrderManager>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
       

        return services;
    }
}

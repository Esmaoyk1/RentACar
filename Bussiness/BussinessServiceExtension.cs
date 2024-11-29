using Bussiness.Abstract;
using Bussiness.Concrete;
using Bussiness.Dtos.Responses.CarResponses;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Bussiness;

public static class BussinessServiceExtension
{

    // metodun amacı, uygulamanızın servislerine iş katmanı ile ilgili bağımlılıkları eklemek ve doğru yapılandırmayı sağlamaktır
    //iş katmanındaki servisler ve doğrulama işlemleri tek bir yerde yapılandırılıp DI konteynerine eklenir.
    public static IServiceCollection AddBussinessServices(this IServiceCollection services)
    {
        services.AddTransient<IBrandService, BrandManager>();
        services.AddTransient<IModelService, ModelManager>();
        services.AddTransient<ICarService, CarManager>();
        services.AddTransient<IOrderService, OrderManager>();
        services.AddTransient<IAuthService,AuthService>();
       
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddFluentValidationAutoValidation(config => 
            config.DisableDataAnnotationsValidation = true)
            .AddFluentValidationClientsideAdapters()
            .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
       
        return services;
    }
}

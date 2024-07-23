
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class DataAccessServiceExtension
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddTransient<IBrandRepository, EfBrandRepository>();
        services.AddTransient<IModelRepository, EfModelRepository>();
        services.AddTransient<ICarRepository, EfCarRepository>();
        services.AddTransient<IOrderRepository, EfOrderRepository>();
        return services;
    }

    //Bu kod parçası, Entity Framework Core ile SQL Server veritabanı bağlantısını ve DbContext sınıfını yapılandırarak, ASP.NET Core uygulamasına veri erişim hizmetlerinin eklenmesini sağlar.
}

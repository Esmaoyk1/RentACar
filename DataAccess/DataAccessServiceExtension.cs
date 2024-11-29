
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;
public static class DataAccessServiceExtension
{

    //veri erişimi ile ilgili servisleri (örneğin, veritabanı bağlantıları, Identity ayarları ve repository'ler) konfigüre edip, IServiceCollection'a eklemektir
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CarContext>(options => options.UseSqlServer(configuration.GetConnectionString("CarContext")));

        services.AddIdentity<User, Role>(opt =>
        {
            opt.User.RequireUniqueEmail = false;
            opt.Password.RequireDigit = false;
            opt.Password.RequiredUniqueChars = 0;
            opt.Password.RequireNonAlphanumeric = false;
            opt.Password.RequiredLength = 2;
            opt.Password.RequireLowercase = false;
            opt.Password.RequireUppercase = false;
            opt.Lockout.AllowedForNewUsers = false;
        })
            .AddEntityFrameworkStores<CarContext>()
            .AddDefaultTokenProviders();

        services.Configure<SecurityStampValidatorOptions>(options => options.ValidationInterval = TimeSpan.FromMinutes(15));

        //her istekte yeni bir örneğin oluşturulması 
        //Repository'ler, veritabanı işlemleri için kullanılan sınıflardır. EfBrandRepository, EfModelRepository, EfCarRepository, ve EfOrderRepository sınıfları, IBrandRepository, IModelRepository, ICarRepository, ve IOrderRepository arayüzlerini uygular.

        services.AddTransient<IBrandRepository, EfBrandRepository>();
        services.AddTransient<IModelRepository, EfModelRepository>();
        services.AddTransient<ICarRepository, EfCarRepository>();
        services.AddTransient<IOrderRepository, EfOrderRepository>();
        return services;
    }

}


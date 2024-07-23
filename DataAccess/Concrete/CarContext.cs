using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete;

public class CarContext : DbContext
{
    public CarContext()
    {
        //NoTracking seçeneğini kullanarak, EF Core yalnızca verileri getirip gereksiz takip işlemini önlemiş olursunuz. Bu da performansı artırır.Bu ayar, yalnızca okuma amaçlı senaryolarda kullanılmalıdır.
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;


        //tüm ilişkili verilerin önceden yüklenmesini sağlar. Bu, daha etkili bir veri yükleme sağlar, ancak bellek kullanımını artırabilir.

        ChangeTracker.LazyLoadingEnabled = false;

        //Normalde, EF Core her erişimde değişiklikleri algılar ve bunu ChangeTracker'da tutar.
        ChangeTracker.AutoDetectChangesEnabled = false;
    }

    //Entity Framework Core uygulamalarında modelin nasıl oluşturulacağını tanımlar.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }


    //DbContext yapılandırmasını özelleştirmek için kullanılır.

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RentACarDb;Trusted_Connection=True;MultipleActiveResultSets=true");
    }


    DbSet<Brand> Brands { get; set; }  //Nesnemiz olan Brand veri tabanındaki Brands ile eşlensin.
    DbSet<Model> Models { get; set; }
    DbSet<Car> Cars { get; set; }

    DbSet<Order> Orders { get; set; }
}


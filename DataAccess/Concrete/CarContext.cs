using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete;

public class CarContext : IdentityDbContext<User,Role,int>
{
     
    private readonly IPasswordHasher<User> passwordHasher;
    public CarContext() { }
    public CarContext(DbContextOptions<CarContext> options, IPasswordHasher<User> _passwordHasher) : base(options)
    {
        passwordHasher = _passwordHasher;
    }

    //Entity Framework Core uygulamalarında modelin nasıl oluşturulacağını tanımlar.
    protected override void OnModelCreating(ModelBuilder modelBuilder)    {
        base.OnModelCreating(modelBuilder);   //temel sınıftaki model oluşturma işlemlerini çalıştırır.



        //Role superAdmin = new() { Id = 1, Name = "superadmin", NormalizedName="SUPERADMIN", 
        //    ConcurrencyStamp = Guid.NewGuid().ToString() };
        //Role admin = new() { Id = 2, Name = "admin", NormalizedName="ADMIN", 
        //    ConcurrencyStamp = Guid.NewGuid().ToString() };

        //modelBuilder.Entity<Role>().HasData(superAdmin,admin);

        //User superAdminUser = new()
        //{
        //    Id = 1,
        //    Name = "esma",
        //    NormalizedUserName = "ESMA",
        //    UserName = "esma",
        //    Email = "esma@gmail.com",
        //    NormalizedEmail = "ESMA@GMAIL.COM",
        //    LastName = "Oyanik",
        //    EmailConfirmed=true,
        //    SecurityStamp= Guid.NewGuid().ToString(),
        //    PhoneNumber="2536372828",
        //    PhoneNumberConfirmed=true,
        //    TwoFactorEnabled=false,
        //    AccessFailedCount=0,
        //    LockoutEnabled=false,
        //    LockoutEnd=null
        //};
        //superAdminUser.PasswordHash = passwordHasher.HashPassword(superAdminUser, "esma");
        //modelBuilder.Entity<User>().HasData(superAdminUser);

        //UserRole userRole = new()
        //{
        //    RoleId = 1,
        //    UserId = 1,
        //};
        //modelBuilder.Entity<UserRole>().HasData(userRole);
    }


    // veri tabanının bağlanacağı sunucuyu tanımlar. 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RentACarDb;Trusted_Connection=True;MultipleActiveResultSets=true");
    }

    // veri tabanındaki tabloları temsil eder. 
    DbSet<Brand> Brands { get; set; }  //Nesnemiz olan Brand veri tabanındaki Brands ile eşlensin.
    DbSet<Model> Models { get; set; }
    DbSet<Car> Cars { get; set; }
    DbSet<Order> Orders { get; set; }
}


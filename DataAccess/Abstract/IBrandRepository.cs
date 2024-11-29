using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IBrandRepository : IEntityRepository<Brand>
{
}


//IBrandRepository, Brand tipi ile çalışacak olan repository sınıfına rehberlik eden bir arayüzdür ve temel veri işlemleri için IEntityRepository arayüzündeki standart yöntemleri kullanır.
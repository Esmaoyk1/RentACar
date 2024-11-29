using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Dtos.Requests.BrandRequest
{
    public class CreateBrandDto : IDto
    {
        public string Name { get; set; }
        
    }
}
//CreateBrandDto sınıfı, yeni bir marka oluşturulması için gerekli olan veriyi taşır ve sadece bir Name özelliğine sahiptir. Bu sınıf DTO olarak tanımlandığı için, genellikle bir API çağrısında, veri giriş ekranında veya başka bir yerden alınan marka adı bilgisini taşıyan bir model olarak kullanılır. IDto arayüzünü implement ederek, bu sınıfın veri taşıyan bir nesne olduğunu belirtir.


//CreateBrandDto sınıfı, yeni bir marka eklemek için gerekli veriyi taşır. Buradaki temel işlev, marka adı gibi bilgileri bir yerden alıp (örneğin bir API'ye gönderilerek) sunucu tarafında işlemek ve veritabanına kaydetmektir. Yani, bir tür veri taşıyıcıdır.
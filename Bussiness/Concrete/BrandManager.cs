using Bussiness.Abstract;
using Bussiness.Dtos.Models;
using Bussiness.Dtos.Requests.BrandRequest;
using Bussiness.Dtos.Responses.BrandResponses;
using Core.Utils.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete
{
    public class BrandManager(IBrandRepository _brandRepository) : IBrandService
    {
        public IResult Add(CreateBrandDto createBrandDto)
        {
            Brand brand = new();
            brand.Name = createBrandDto.Name;
            _brandRepository.Add(brand);
            return new SuccessResult("Marka başarıyla eklendi");
        }

        public IResult Delete(int id)
        {
            Brand brand = _brandRepository.Get(x => x.Id == id);
            _brandRepository.Delete(brand);
            return new SuccessResult("Marka başarıyla silindi");
        }

        public IDataResult<GetBrandDto> Get(int id)
        {
            Brand brand = _brandRepository.Get(x => x.Id == id);

            GetBrandDto result = new GetBrandDto();

            result.Name = brand.Name;
            result.CreatedTime= DateTime.Now;
            result.Status = brand.Status;
          
            return new SuccessDataResult<GetBrandDto>(result, "Marka getirildi");
        }

        public IDataResult<GetAllBrandModel> GetAll()
        {
            GetAllBrandModel result = new();
            List<GetAllBrandDto> temp = new();
            List<Brand> brands = _brandRepository.GetAll();
            foreach (var brand in brands)
            {
                GetAllBrandDto getAllBrandDto = new();
                getAllBrandDto.Id = brand.Id;
                getAllBrandDto.Name = brand.Name;
                getAllBrandDto.CreatedDate = DateTime.Now;
                getAllBrandDto.Status = brand.Status;

                temp.Add(getAllBrandDto);

            }

            result.Items = temp;
            return new SuccessDataResult<GetAllBrandModel>(result, "Markalar listelendi");
        }

        public IResult Update(UpdateBrandDto updateBrandDto)
        {
            Brand brand =_brandRepository.Get(x=>x.Id == updateBrandDto.Id);
            brand.Name = updateBrandDto.Name;
            brand.UpdatedDate = DateTime.Now;
            
            _brandRepository.Update(brand);
            return new SuccessResult("Marka başarıyla güncellendi");
        }
    }
}

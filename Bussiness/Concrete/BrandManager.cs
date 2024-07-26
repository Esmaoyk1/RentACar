using AutoMapper;
using Bussiness.Abstract;
using Bussiness.Dtos.Models;
using Bussiness.Dtos.Requests.BrandRequest;
using Bussiness.Dtos.Responses.BrandResponses;
using Core.Utils.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete;

public class BrandManager(IBrandRepository _brandRepository, IMapper _mapper) : IBrandService
{
    public IResult Add(CreateBrandDto createBrandDto)
    {
        var checkName = IsBrandNameExist(createBrandDto.Name);
        if (checkName.Success == false) return checkName;

        Brand brand = _mapper.Map<Brand>(createBrandDto);
        brand.CreatedDate = DateTime.Now;
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
        GetBrandDto result = _mapper.Map<GetBrandDto>(brand);
        return new SuccessDataResult<GetBrandDto>(result, "Marka getirildi");
    }

    public IDataResult<GetAllBrandModel> GetAll()
    {
        GetAllBrandModel result = new();
        List<Brand> brands = _brandRepository.GetAll();
        List<GetAllBrandDto> temp = _mapper.Map<List<GetAllBrandDto>>(brands);
        result.Items = temp;
        return new SuccessDataResult<GetAllBrandModel>(result, "Markalar listelendi");
    }

    public IResult Update(UpdateBrandDto updateBrandDto)
    {
        var checkName = IsBrandNameExist(updateBrandDto.Name);
        if (checkName.Success == false) return checkName;

        Brand brand =_brandRepository.Get(x=>x.Id == updateBrandDto.Id);
        brand.Name = updateBrandDto.Name;
        brand.UpdatedDate = DateTime.Now;
        _brandRepository.Update(brand);
        return new SuccessResult("Marka başarıyla güncellendi");
    }

    private IResult IsBrandNameExist(string name)
    {
        Brand brand = _brandRepository.Get(x => x.Name == name);
        if (brand != null) return new ErrorResult("Marka mevuct..");
        return new SuccessResult();
    }


}

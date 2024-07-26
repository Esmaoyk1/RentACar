using AutoMapper;
using Bussiness.Abstract;
using Bussiness.Dtos.Models;
using Bussiness.Dtos.Requests.BrandRequest;
using Bussiness.Dtos.Requests.ModelRequest;
using Bussiness.Dtos.Responses.BrandResponses;
using Bussiness.Dtos.Responses.ModelResponses;
using Core.Utils.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Bussiness.Concrete
{
    public class ModelManager(IModelRepository _modelRepository, IBrandService _brandService, IMapper _mapper) : IModelService
    {
        public IResult Add(CreateModelDto createModelDto)
        {
            // Öncelikle, verilen model adının daha önce kaydedilip kaydedilmediğini kontrol ediyoruz.
            var checkName = IsModelNameExist(createModelDto.Name);

            // Eğer model adı daha önce kullanılmışsa, yani checkName.Success == false ise,
            // checkName nesnesini geri döndürüyoruz.
            if (checkName.Success == false) return checkName;
            Model model = _mapper.Map<Model>(createModelDto);
            _modelRepository.Add(model);
            return new SuccessResult("Model başarıyla eklendi");
        }

        public IResult Delete(int id)
        {
            Model model = _modelRepository.Get(x => x.Id == id);
            _modelRepository.Delete(model);
            return new SuccessResult("Model başarıyla silindi");
        }


        public IDataResult<GetModelDto> Get(int id)
        {
            Model model = _modelRepository.Get(x => x.Id == id);
            GetModelDto result = _mapper.Map<GetModelDto>(model);
            return new SuccessDataResult<GetModelDto>(result, "Marka getirildi");
        }

        public IDataResult<GetAllModelModel> GetAll()
        {
            GetAllModelModel result = new();
            List<Model> models = _modelRepository.GetAll();
            List<GetAllModelDto> temp = _mapper.Map<List<GetAllModelDto>>(models);
            result.Items = temp;
            return new SuccessDataResult<GetAllModelModel>(result, "Modeller listelendi");
        }

        public IResult Update(UpdateModelDto updateModelDto)
        {
            var checkName = IsModelNameExist(updateModelDto.Name);
            if (checkName.Success == false) return checkName;

            Model model = _modelRepository.Get(x => x.Id == updateModelDto.Id);
            model.Name = updateModelDto.Name;
            model.UpdatedDate = DateTime.Now;

            _modelRepository.Update(model);
            return new SuccessResult("Model başarıyla güncellendi");
        }


        private IResult IsModelNameExist(string name)
        {

            // Verilen model adının daha önce kaydedilip kaydedilmediğini kontrol ediyoruz.
            Model model = _modelRepository.Get(x => x.Name == name);
            // Eğer model nesnemiz null değilse, yani model adı zaten kullanılmışsa,
            // ErrorResult döndürüyoruz ve "Model mevcut.." mesajını set ediyoruz.
            if (model != null) return new ErrorResult("Model mevuct..");
            return new SuccessResult();
        }
    }
}

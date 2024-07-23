using AutoMapper;
using Bussiness.Abstract;
using Bussiness.Dtos.Requests.ModelRequest;
using Bussiness.Dtos.Responses.ModelResponses;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete
{
    public class ModelManager(IModelRepository _modelRepository ,IBrandService _brandService, IMapper _mapper) : IModelService
    {
        public void Add(CreateModelDto createModelDto)
        {
            Model model = _mapper.Map<Model>(createModelDto);
            _modelRepository.Add(model);
        }

        public void Delete(int id)
        {
            Model model = _modelRepository.Get(x => x.Id == id);
            _modelRepository.Delete(model);
        }


        public GetModelDto Get(int id)
        {
            Model model = _modelRepository.Get(x => x.Id == id);

            GetModelDto result = new GetModelDto();
            result.Name = model.Name;
            result.BrandId = model.BrandId;
            result.CreatedDate = model.CreatedDate;
            result.Status = model.Status;


            return result;



            //public GetModelDto Get(int id)
            //{
            //    Model model = _modelRepository.Get(x => x.Id == id);

            //    if (model == null)
            //    {
            //        throw new Exception($"Model with ID {id} not found.");
            //    }

            //    return _mapper.Map<GetModelDto>(model);
            //}


        }

        public List<GetAllModelDto> GetAll()
        {
            List<GetAllModelDto> result = new();
            List<Model> models = _modelRepository.GetAll();
            foreach (var model in models)
            {
                GetAllModelDto getAllModelDto = new();
                getAllModelDto.Id = model.Id;
                getAllModelDto.Name = model.Name;
                getAllModelDto.CreatedDate = DateTime.Now;
                getAllModelDto.Status = model.Status;
                getAllModelDto.BrandName = _brandService.Get(model.BrandId).Data.Name;

                result.Add(getAllModelDto);
            }
            return result;
        }

        public void Update(UpdateModelDto updateModelDto)
        {
            Model model = _modelRepository.Get(x => x.Id == updateModelDto.Id);
            model.Name = updateModelDto.Name;
            model.UpdatedDate = DateTime.Now;

            _modelRepository.Update(model);
        }
    }
}

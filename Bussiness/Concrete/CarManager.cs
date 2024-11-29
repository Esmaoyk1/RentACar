using AutoMapper;
using Bussiness.Abstract;
using Bussiness.Dtos.Models;
using Bussiness.Dtos.Requests.BrandRequest;
using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Requests.OrderRequest;
using Bussiness.Dtos.Responses.BrandResponses;
using Bussiness.Dtos.Responses.CarResponses;
using Core.Utils.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarManager(ICarRepository _carRepository, IMapper _mapper, IModelRepository _modelRepository) : ICarService
    {
        public IResult Add(CreateCarDto createCarDto)
        {
            var checkModelExist = HasModelExist(createCarDto.ModelId);
            if (checkModelExist.Success == false)
            { return checkModelExist; } // Hata mesajını döndür

            Car car = _mapper.Map<Car>(createCarDto);
            _carRepository.Add(car);
            return new SuccessResult("Araba Başarıyla yüklendi");
        }

        public IResult Delete(int id)
        {
            Car car = _carRepository.Get(x => x.Id == id);
            _carRepository.Delete(car);
            return new SuccessResult("Araba başarıyla silindi");

        }

        //public IDataResult<GetCarDto> Get(int id)
        //{
        //    Car car = _carRepository.Get(x => x.Id == id);
        //    GetCarDto result = _mapper.Map<GetCarDto>(car);
        //    return new SuccessDataResult<GetCarDto>(result, "Araba Getirildi");

        //}

        public IDataResult<GetCarDto> Get(int id)
        {
            Car car = _carRepository.Get(x => x.Id == id);

            if (car == null) // Eğer araba bulunamazsa
            {
                return new ErrorDataResult<GetCarDto>(null, "ID değeri bulunamadı.");
            }

            GetCarDto result = _mapper.Map<GetCarDto>(car);
            return new SuccessDataResult<GetCarDto>(result, "Araba getirildi.");
        }


        public IDataResult<GetAllCarModel> GetAll()
        {
            GetAllCarModel result = new();
            List<Car> cars = _carRepository.GetAll();
            List<GetAllCarDto> temp = _mapper.Map<List<GetAllCarDto>>(cars);
            result.Items = temp;
            return new SuccessDataResult<GetAllCarModel>(result, "Arabalar listelendi");
        }

        public IResult Update(UpdateCarDto updateCarDto)
        {
            Car car = _carRepository.Get(x => x.Id == updateCarDto.Id);
            car.Description = updateCarDto.Description;
            _carRepository.Update(car);
            return new SuccessResult("Araba başarıyla güncellendi");

        }

        public IDataResult<GetAllCarModel> GetListByRentalStatus()
        {
            GetAllCarModel result = new();
            List<Car> cars = _carRepository.GetAll().Where(x => x.RentalStatus == RentalStatus.Vacant).ToList();
            List<GetAllCarDto> temp = _mapper.Map<List<GetAllCarDto>>(cars);
            result.Items = temp;
            return new SuccessDataResult<GetAllCarModel>(result, "Arabalar listelendi");
        }


        public IResult UpdateRentalStatus(int carId, RentalStatus newRentalStatus)
        {
            Car car = _carRepository.Get(x => x.Id == carId);
            if (car == null) return new ErrorResult("Araba bulunamadı");
            car.RentalStatus = newRentalStatus;
            _carRepository.Update(car);
            return new SuccessResult($"Aracın kiralama durumu {newRentalStatus} olarak güncellendii..");

        }

        //Bussiness Rules
        private IResult HasModelExist(int modelId)
        {
            Model model = _modelRepository.Get(x => x.Id == modelId);
            if (model == null) return new ErrorResult($"Böyle bir model yok..");
            return new SuccessResult();
        }

    }

}

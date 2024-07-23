using AutoMapper;
using Bussiness.Abstract;
using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Responses.CarResponses;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarManager(ICarRepository _carRepository,IMapper _mapper) : ICarService
    {
        public void Add(CreateCarDto createCarDto)
        {
            Car car = _mapper.Map<Car>(createCarDto);
            _carRepository.Add(car);
        }

        public void Delete(int id)
        {
            Car car = _carRepository.Get(x => x.Id == id);
            _carRepository.Delete(car);
        }

        public GetCarDto Get(int id)
        {
            Car car = _carRepository.Get(x=>x.Id == id);    
            GetCarDto carDto = _mapper.Map<GetCarDto>(car);
            return carDto;


        }

        public List<GetAllCarDto> GetAll()
        {
            List<Car> cars = _carRepository.GetAll();
            List<GetAllCarDto> carsDto = _mapper.Map<List<GetAllCarDto>>(cars);
            return carsDto;

        }

        public void Update(UpdateCarDto updateCarDto)
        {
            Car car =_mapper.Map<Car>(updateCarDto);
            _carRepository.Update(car);
        }
    }
}

using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Responses.CarResponses;

namespace Bussiness.Abstract;

public interface ICarService
{
    List<GetAllCarDto> GetAll();
    GetCarDto Get(int id);
    void Add(CreateCarDto createCarDto);
    void Delete(int id);
    void Update(UpdateCarDto updateCarDto);
}

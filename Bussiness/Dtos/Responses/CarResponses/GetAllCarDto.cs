using Core.Entities;
using Entities.Concrete;

namespace Bussiness.Dtos.Responses.CarResponses;

public class GetAllCarDto : IDto
{
    public string ModelName {  get; set; }
    public string Title { get; set; }
    public decimal DailyPrice { get; set; }
    public string Description { get; set; }
    public string CoverImage { get; set; }
    public int Year { get; set; }
    public string FuelType { get; set; }
    public string RentalStatus { get; set; }
    public string Transmission { get; set; }


}

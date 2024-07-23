using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Dtos.Requests.CarRequest
{
    public class CreateCarDto : IDto

    {
        public int ModelId { get; set; }
        public string Title { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public int Year {  get; set; }
        public int FuelType {  get; set; }
        public int RentalStatus { get; set; }
        public int Transmission { get; set;}

    }


}

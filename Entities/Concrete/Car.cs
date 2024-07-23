using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:Entity
    {
        public int ModelId {  get; set; }
        public string Title { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description {  get; set; }
        public string CoverImage { get; set; }
        public int Year {  get; set; }
        public FuelType FuelType { get; set; }
        public Transmission Transmission { get; set; }

        public RentalStatus RentalStatus { get; set; }

        public virtual Model Model { get; set; }

        public virtual Order Order { get; set; }




    }
}

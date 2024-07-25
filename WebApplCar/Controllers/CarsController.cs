using Bussiness.Abstract;
using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Requests.ModelRequest;
using Bussiness.Dtos.Responses.CarResponses;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController(ICarService carService) : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(carService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
            return Ok(carService.Get(id));  
        }


        [HttpPost]
        public ActionResult Add([FromBody] CreateCarDto createModel)
        {
            carService.Add(createModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            carService.Delete(id);
            return Ok();
        }




        [HttpPut]
        public ActionResult Update([FromBody] UpdateCarDto updatedModel)
        {
            carService.Update(updatedModel);


            return Ok();
        }

        [HttpGet("GetListByRentalStatus")]
        public ActionResult GetListByRentalStatus()
        {
            
            return Ok(carService.GetListByRentalStatus());
        }




    }
}

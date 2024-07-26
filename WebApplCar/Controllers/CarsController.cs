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
            var result = carService.GetAll();
            if(!result.Success) return BadRequest(result);  //Yanlış bir giriş olduğu durumda  400                                                                  Hata Kodu gonder.
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
            //  return Ok(carService.Get(id));  
            var result = carService.Get(id);
            if (!result.Success) return BadRequest(result);
            return Ok(result);

        }


        [HttpPost]
        public ActionResult Add([FromBody] CreateCarDto createCarDto)
        {

            //  return Ok(carService.Add(createCarDto));

            var result = carService.Add(createCarDto);
            if (!result.Success) return BadRequest(result);
            return Ok(result);

        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            //carService.Delete(id);
            //return Ok();

            var result = carService.Delete(id);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpPut]
        public ActionResult Update([FromBody] UpdateCarDto updatedModel)
        {
            //carService.Update(updatedModel);
            //return Ok();

            var result = carService.Update(updatedModel);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("GetListByRentalStatus")]
        public ActionResult GetListByRentalStatus()
        {
            
          //  return Ok(carService.GetListByRentalStatus());

            var result = carService.GetListByRentalStatus();
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }
    }
}

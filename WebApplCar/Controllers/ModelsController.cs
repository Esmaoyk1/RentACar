using Bussiness.Abstract;
using Bussiness.Dtos.Requests.BrandRequest;
using Bussiness.Dtos.Requests.ModelRequest;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController(IModelService modelService ): ControllerBase
    {

        [HttpGet]        //Veri talep etmek için .

        public ActionResult GetAll()
        {
            return Ok(modelService.GetAll());
        }



        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
            return Ok(modelService.Get(id)); 
        }

        [HttpPost]
        public ActionResult Add([FromBody] CreateModelDto createModel)
        {
            modelService.Add(createModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            modelService.Delete(id);
            return Ok();
        }




        [HttpPut]
        public ActionResult Update([FromBody] UpdateModelDto updatedModel)
        {
            modelService.Update(updatedModel);


            return Ok();
        }

    }
}

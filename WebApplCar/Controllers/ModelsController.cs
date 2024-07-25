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
            
            return Ok(modelService.Add(createModel));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
           
            return Ok(modelService.Delete(id));
        }




        [HttpPut]
        public ActionResult Update([FromBody] UpdateModelDto updatedModel)
        {
            return Ok(modelService.Update(updatedModel));
        }

    }
}

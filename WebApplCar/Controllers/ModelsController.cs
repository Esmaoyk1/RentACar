using Bussiness.Abstract;
using Bussiness.Dtos.Requests.BrandRequest;
using Bussiness.Dtos.Requests.ModelRequest;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController(IModelService modelService) : ControllerBase
    {

        [HttpGet]        //Veri talep etmek için .
        public ActionResult GetAll()
        {
            //  return Ok(modelService.GetAll());
            var result = modelService.GetAll();
            if (!result.Success)  return BadRequest(result); 
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
           // return Ok(modelService.Get(id));
           var result = modelService.Get(id);
            if (!result.Success)  return BadRequest(result) ; 
            return Ok(result);
        }

        [HttpPost]
        public ActionResult Add([FromBody] CreateModelDto createModel)
        {
           // return Ok(modelService.Add(createModel));
           var result = modelService.Add(createModel);
            if (!result.Success)  return BadRequest(result); 
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
          //  return Ok(modelService.Delete(id));
          var result = modelService.Delete(id);
            if (!result.Success)  return BadRequest(result); 
            return Ok(result);
        }




        [HttpPut]
        public ActionResult Update([FromBody] UpdateModelDto updatedModel)
        {
           // return Ok(modelService.Update(updatedModel));
           var result = modelService.Update(updatedModel);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
            
        }

    }
}

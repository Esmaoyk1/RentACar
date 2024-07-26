using Bussiness.Abstract;
using Bussiness.Dtos.Requests.BrandRequest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;


namespace WebAppCar.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController(IBrandService brandService) : ControllerBase
{
    [HttpGet]        //Veri talep etmek için .
    public ActionResult GetAll()
    {
        var result = brandService.GetAll();
        if(!result.Success) { return BadRequest(result); }
        return Ok(result);
    }

    [HttpGet("{id}")]
    public ActionResult GetById([FromRoute] int id)
    {
      //  return Ok(brandService.Get(id));  // 200 kodu gonderiyor

        var result = brandService.Get(id);
        if(!result.Success) { return NotFound(result); }
        return Ok(result);
    }

    [HttpPost]
    public ActionResult Add([FromBody] CreateBrandDto createModel)
    {
       // return Ok(brandService.Add(createModel));
       var result = brandService.Add(createModel);
        if(!result.Success) { return BadRequest(result); }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete([FromRoute]int id)
    {
       //  return  Ok(brandService.Delete(id));
       var result = brandService.Delete(id);
        if(!result.Success) { return BadRequest(result); }
        return Ok(result);

    }

    [HttpPut("update")]
    public ActionResult Update([FromBody] UpdateBrandDto updatedModel)
    {
       // return Ok(brandService.Update(updatedModel));
       var result = brandService.Update(updatedModel);
        if(!result.Success) { return BadRequest(result); }
        return Ok(result);
    }
}

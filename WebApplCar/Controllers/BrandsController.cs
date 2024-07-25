using Bussiness.Abstract;
using Bussiness.Dtos.Requests.BrandRequest;
using Microsoft.AspNetCore.Mvc;


namespace WebAppCar.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController(IBrandService brandService) : ControllerBase
{
    [HttpGet]        //Veri talep etmek için .
    public ActionResult GetAll()
    {
        return Ok(brandService.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult GetById([FromRoute] int id)
    {
        return Ok(brandService.Get(id));  // 200 kodu gonderiyor
    }

    [HttpPost]
    public ActionResult Add([FromBody] CreateBrandDto createModel)
    {
        return Ok(brandService.Add(createModel));
    }

    [HttpDelete("{id}")]
    public ActionResult Delete([FromRoute]int id)
    {
         return  Ok(brandService.Delete(id));
    }

    [HttpPut("update")]
    public ActionResult Update([FromBody] UpdateBrandDto updatedModel)
    {
        return Ok(brandService.Update(updatedModel));
    }
}

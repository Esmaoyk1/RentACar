using Bussiness.Abstract;
using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Requests.OrderRequest;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController(IOrderService orderService) : ControllerBase

    {
        [HttpGet]
        public ActionResult GetAll()
        {
           // return Ok(orderService.GetAll());
           var result = orderService.GetAll();
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
            //  return Ok(orderService.Get(id));
            var result = orderService.Get(id);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }




        [HttpPost]
        public ActionResult Add([FromBody] CreateOrderDto createModel)
        {
            //return Ok(orderService.Add(createModel));
            var result = orderService.Add(createModel);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            //return Ok(orderService.Delete(id));
            var result = orderService.Delete(id);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }



        [HttpPut]

        public ActionResult Update([FromBody] UpdateOrderDto updateOrder)
        {
            //return Ok(orderService.Update(updateOrder));
            var result = orderService.Update(updateOrder);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }
        



    }
}

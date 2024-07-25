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
            return Ok(orderService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
            return Ok(orderService.Get(id));
        }




        [HttpPost]
        public ActionResult Add([FromBody] CreateOrderDto createModel)
        {
            orderService.Add(createModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            orderService.Delete(id);
            return Ok();
        }



        [HttpPut]

        public ActionResult Update([FromBody] UpdateOrderDto updateOrder)
        {
            orderService.Update(updateOrder);
            return Ok();
        }
        



    }
}

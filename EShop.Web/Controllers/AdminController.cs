using EShop.Domain.Domain;
using EShop.Service.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EShop.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public AdminController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/<AdminController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orderService.GetAllOrders();
        }

        // GET api/<AdminController>/5
        [HttpGet("{id}")]
        public Order Get(Guid id)
        {
            return _orderService.GetDetailsForOrder(id);
        }

        // POST api/<AdminController>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            _orderService.CreateNewOrder(order);
        }

        // PUT api/<AdminController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Order order)
        {
            _orderService.UpdateExistingOrder(order);
        }

        // DELETE api/<AdminController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _orderService.DeleteOrder(id);
        }
    }
}

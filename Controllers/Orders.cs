using System.Collections;
using Freshprints.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Freshprints.Controllers
{
    [Route("api/users/{userName}/orders")]
    [ApiController]
    [Authorize]
    public class Orders : Controller
    {
        // GET
        public IActionResult Index(int itemId)
        {
            return Ok("aha" + itemId);
        }    
        
        //GET api/orders/:id
        // particular order of a user
        [HttpGet("{id}")]
        public ActionResult<IEnumerable> GetAllOrders(string userName, int id)
        {
            var orders = OrderItemMockRepository.GetAllOrders(userName, id);
            return Ok(orders);
        }
        
        
        //GET api/orders/
        // all orders of user
        [HttpGet]
        public ActionResult<IEnumerable> GetAllOrders(string userName)
        {
            var orders = OrderItemMockRepository.GetAllOrders(userName);
            return Ok(orders);
        }
        
    }
}
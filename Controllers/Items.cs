using System.Collections.Generic;
using Freshprints.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Freshprints.Controllers
{
    [Authorize]
    [Route("api/items")]
    [ApiController]
    public class Items : Controller
    {
        
        
        //GET api/items/
        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetAllCommands()
        {
            var items = ItemsMockRepository.GetAllItems();
            return Ok(items);
        }
        
        //GET api/items/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetCommandById(int id)
        {
            if (ItemsMockRepository.GetItemById(id) == null)
            {
                return NotFound("Item Not Found");
            }
            return Ok(ItemsMockRepository.GetItemById(id));
            
        }
        
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Freshprints.Controllers
{
    [Route("/")]
    public class Index : Controller
    {
        // GET
        public IActionResult Hey()
        {
            return Ok("Welcome to Fresh Prints");
        }
    }
}
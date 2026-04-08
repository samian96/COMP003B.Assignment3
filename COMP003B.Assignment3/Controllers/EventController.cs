using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers
{
    [Route("event")]
    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]

        public IActionResult eventCode()
        {
            return View();
        }
    }
}

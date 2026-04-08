using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers
{
    [Route("eventRegistration")]
    public class EventController : Controller
    {
        [HttpGet("/event/register/{EventCode}")]

        public IActionResult EventCode()
        {
            return View();
        }

    }
}

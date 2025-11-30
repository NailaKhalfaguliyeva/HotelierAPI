using Microsoft.AspNetCore.Mvc;

namespace Hotelier.API.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

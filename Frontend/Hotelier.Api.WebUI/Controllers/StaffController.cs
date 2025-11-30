using Microsoft.AspNetCore.Mvc;

namespace Hotelier.Api.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

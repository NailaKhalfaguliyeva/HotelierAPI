using Microsoft.AspNetCore.Mvc;

namespace Hotelier.Api.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

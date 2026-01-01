using Microsoft.AspNetCore.Mvc;

namespace Hotelier.Api.WebUI.Controllers
{
    public class MessageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.Api.WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        [AllowAnonymous]
        public IActionResult Error404()
        {
            return View();
        }
    }
}

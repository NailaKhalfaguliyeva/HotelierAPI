using Microsoft.AspNetCore.Mvc;

namespace Hotelier.Api.WebUI.ViewComponents.DashBoard
{
    public class _DashboardScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
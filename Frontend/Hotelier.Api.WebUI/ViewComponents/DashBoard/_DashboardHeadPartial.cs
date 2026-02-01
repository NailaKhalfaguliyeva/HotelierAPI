using Microsoft.AspNetCore.Mvc;

namespace Hotelier.Api.WebUI.ViewComponents.DashBoard
{
    public class _DashboardHeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

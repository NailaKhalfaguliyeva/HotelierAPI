using Microsoft.AspNetCore.Mvc;

namespace Hotelier.Api.WebUI.ViewComponents.Default
{
    public class _ReservationPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
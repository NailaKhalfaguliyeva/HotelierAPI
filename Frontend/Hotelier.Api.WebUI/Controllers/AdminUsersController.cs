using Hotelier.Api.EntityLayer.Concrete;
using Hotelier.Api.WebUI.Dtos.AppUserDto;
using Hotelier.Api.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotelier.Api.WebUI.Controllers
{
    public class AdminUsersController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUsersController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            //    var client = _httpClientFactory.CreateClient();
            //    var responseMessage = await client.GetAsync("http://localhost:5221/api/AppUser");
            //    if (responseMessage.IsSuccessStatusCode)
            //    {
            //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
            //        var values = JsonConvert.DeserializeObject<List<ResultAppUserDto>>(jsonData);
            //        return View(values);
            //    }
            return View();
        }

        public async Task<IActionResult> UserList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5221/api/AppUser");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAppUserListDto>>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}

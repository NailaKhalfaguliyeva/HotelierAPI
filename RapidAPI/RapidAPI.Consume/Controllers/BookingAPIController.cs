using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidAPI.Consume.Models;

namespace RapidAPI.Consume.Controllers
{
    [Route("rapid/booking")]
    public class BookingAPIController : Controller
    {
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?adults_number=2&children_number=2&units=metric&page_number=0&checkin_date=2026-01-31&checkout_date=2026-02-01&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&dest_type=city&dest_id=-1456928&order_by=popularity&include_adjacency=true&room_number=1&filter_by_currency=EUR&locale=en-gb"),
                Headers =
    {
        { "x-rapidapi-key", "5aef0cb932msh58c539ed1ec8e60p12e54bjsn25909f1139d1" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                return View(values.result.ToList());
            }            
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidAPI.Consume.Models;

namespace RapidAPI.Consume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if (string.IsNullOrEmpty(cityName))
            {
                List<BookingLocationSearchViewModel> model = new List<BookingLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
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
                    model = JsonConvert.DeserializeObject<List<BookingLocationSearchViewModel>>(body);
                    return View(model.Take(1).ToList());
                }
            }
            else
            {
                List<BookingLocationSearchViewModel> model = new List<BookingLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
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
                    model = JsonConvert.DeserializeObject<List<BookingLocationSearchViewModel>>(body);
                    return View(model.Take(1).ToList());
                }
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidAPI.Consume.Models;

namespace RapidAPI.Consume.Controllers
{
    public class IMBDController : Controller
    {
        List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "5aef0cb932msh58c539ed1ec8e60p12e54bjsn25909f1139d1" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                return View(apiMovieViewModels);
            }
        }
    }
}

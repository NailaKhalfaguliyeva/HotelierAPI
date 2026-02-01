using Hotelier.Api.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using System.Text;

namespace Hotelier.Api.WebUI.Controllers
{
    [AllowAnonymous]
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new CreateBookingDto());
        }

       
        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView((new CreateBookingDto()));
        }

        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
            createBookingDto.Description = "New Booking";
            createBookingDto.Status = "Awaiting Approval";
            createBookingDto.City = "Baku";
            createBookingDto.Country = "Azerbaijan";

            var jsonCheckInDate = createBookingDto.Checkin.ToString("yyyy-MM-ddTHH:mm:ss");
            var jsonCheckOutDate = createBookingDto.CheckOut.ToString("yyyy-MM-ddTHH:mm:ss");

            
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage= await client.PostAsync("http://localhost:5221/api/Booking", stringContent);

            if (!responseMessage.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, "Reservation could not be created. Please try again.");
                return View("Index", createBookingDto);
            }

            return RedirectToAction("Index", "Default");
        }
    }
}

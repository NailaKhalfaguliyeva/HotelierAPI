using System.ComponentModel.DataAnnotations;

namespace Hotelier.Api.WebUI.Dtos.BookingDto
{
    public class CreateBookingDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email format is wrong")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Check-in date is required")]
        public DateTime Checkin { get; set; }
        [Required(ErrorMessage = "Check-out date is required")]
        public DateTime CheckOut { get; set; }
        [Range(1, 10)]
        public string AdultCount { get; set; }
        [Range(0, 10)]
        public string ChildCount { get; set; }
        [Range(1, 10)]
        public string RoomCount { get; set; }
        public string? SpecialRequest { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }        
        public string City { get; set; }        
        public string Country { get; set; }        
    }

}


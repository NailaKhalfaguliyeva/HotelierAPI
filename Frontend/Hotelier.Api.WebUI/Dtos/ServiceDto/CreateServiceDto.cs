using System.ComponentModel.DataAnnotations;

namespace Hotelier.Api.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Enter service icon link")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Enter service title")]
        [StringLength(100, ErrorMessage = "Service Title can be up to 100 characters")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

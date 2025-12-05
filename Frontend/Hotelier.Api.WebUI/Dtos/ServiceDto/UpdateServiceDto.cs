using System.ComponentModel.DataAnnotations;

namespace Hotelier.Api.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Enter service icon link")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Enter service title")]
        [StringLength(100, ErrorMessage = "Service Title can be up to100 characters ")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter service description")]
        [StringLength(500, ErrorMessage = "Service Description can be up to 500 characters")]
        public string Description { get; set; }
    }
}

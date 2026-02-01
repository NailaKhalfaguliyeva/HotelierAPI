using System.ComponentModel.DataAnnotations;

namespace Hotelier.Api.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Name Field Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname Field Required")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Username Field Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email Field Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password Field Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Repeat Password Field Required")]
        [Compare("Password", ErrorMessage = "Passwords Do Not Match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "City Field Required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Country Field Required")]
        public string? Country { get; set; }
        public string? Gender { get; set; }
        public string? WorkDepartment { get; set; }
        public int WorkLocationID { get; set; }
        public string? ImageUrl { get; set; }
    }

}

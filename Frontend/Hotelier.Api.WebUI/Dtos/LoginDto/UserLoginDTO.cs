using System.ComponentModel.DataAnnotations;

namespace Hotelier.Api.WebUI.Dtos.LoginDto
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "Enter Your Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }
    }
}

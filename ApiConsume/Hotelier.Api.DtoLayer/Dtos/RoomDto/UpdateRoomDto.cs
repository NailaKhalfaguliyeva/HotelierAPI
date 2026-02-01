
using System.ComponentModel.DataAnnotations;


namespace Hotelier.Api.DtoLayer.Dtos.RoomDto
{
   public class UpdateRoomDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Please write the room number")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Please enter the room title image.")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please write the price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter room title information")]
        [StringLength(100,ErrorMessage = "Please enter a maximum of 100 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please write the room count")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Please write the bath count")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Please Enter the Wifi Number")]
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Please write the description")]
        public string Description { get; set; }
    }
}

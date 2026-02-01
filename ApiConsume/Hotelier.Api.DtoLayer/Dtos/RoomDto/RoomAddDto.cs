
using System.ComponentModel.DataAnnotations;


namespace Hotelier.Api.DtoLayer.Dtos.RoomDto
{
   public class RoomAddDto
    {
        [Required(ErrorMessage = "Please write the room number")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please write the price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please write the room title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please write the room count")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Please write the bath count")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Please Enter the Wifi Number")]
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Please Enter Room Description")]
        public string Description { get; set; }
    }
}

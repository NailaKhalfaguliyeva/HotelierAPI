using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}

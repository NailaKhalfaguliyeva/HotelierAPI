using AutoMapper;
using Hotelier.Api.DtoLayer.Dtos.RoomDto;
using Hotelier.Api.EntityLayer.Concrete;

namespace HotelierAPI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        protected AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}

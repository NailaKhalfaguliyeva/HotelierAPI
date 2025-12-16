using AutoMapper;
using Hotelier.Api.EntityLayer.Concrete;
using Hotelier.Api.WebUI.Dtos.AboutDto;
using Hotelier.Api.WebUI.Dtos.BookingDto;
using Hotelier.Api.WebUI.Dtos.LoginDto;
using Hotelier.Api.WebUI.Dtos.RegisterDto;
using Hotelier.Api.WebUI.Dtos.ServiceDto;
using Hotelier.Api.WebUI.Dtos.SubscribeDto;

namespace Hotelier.Api.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        protected AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            
            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<UserLoginDTO, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();         
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
        }
    }
}

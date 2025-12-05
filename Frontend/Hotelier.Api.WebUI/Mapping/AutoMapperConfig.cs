using AutoMapper;
using Hotelier.Api.EntityLayer.Concrete;
using Hotelier.Api.WebUI.Dtos.ServiceDto;

namespace Hotelier.Api.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        protected AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
        }
    }
}

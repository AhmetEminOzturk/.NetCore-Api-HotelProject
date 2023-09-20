using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto.Requests;
using HotelProject.WebUI.Dtos.RegisterDto.Requests;
using HotelProject.WebUI.Dtos.ServiceDto.Requests;
using HotelProject.WebUI.Dtos.ServiceDto.Responses;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<DisplayServiceResponse,Service>().ReverseMap();
            CreateMap<CreateServiceRequest,Service>().ReverseMap();
            CreateMap<UpdateServiceRequest,Service>().ReverseMap();

            CreateMap<CreateUserRequest,AppUser>().ReverseMap();
            CreateMap<LoginUserRequest,AppUser>().ReverseMap();
        }
    }
}

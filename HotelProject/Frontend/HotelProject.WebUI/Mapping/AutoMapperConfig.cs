using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto.Requests;
using HotelProject.WebUI.Dtos.AboutDto.Responses;
using HotelProject.WebUI.Dtos.LoginDto.Requests;
using HotelProject.WebUI.Dtos.RegisterDto.Requests;
using HotelProject.WebUI.Dtos.RoomDto.Responses;
using HotelProject.WebUI.Dtos.ServiceDto.Requests;
using HotelProject.WebUI.Dtos.ServiceDto.Responses;
using HotelProject.WebUI.Dtos.StaffDto.Responses;
using HotelProject.WebUI.Dtos.SubscribeDto.Requests;

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

            CreateMap<CreateAboutRequest, About>().ReverseMap();
            CreateMap<UpdateAboutRequest, About>().ReverseMap();
            CreateMap<DisplayAboutResponse, About>().ReverseMap();
            
            CreateMap<DisplayRoomResponse, Room>().ReverseMap();
            CreateMap<DisplayStaffResponse, Staff>().ReverseMap();

            CreateMap<CreateSubscribeRequest, Subscribe>().ReverseMap();
        }
    }
}

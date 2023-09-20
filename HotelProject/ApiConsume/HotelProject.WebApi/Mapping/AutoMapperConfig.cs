using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto.Requests;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddRoomRequest,Room>().ReverseMap();
            CreateMap<UpdateRoomRequest,Room>().ReverseMap();
        }
    }
}

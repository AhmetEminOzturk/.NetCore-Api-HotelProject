using AutoMapper;
using HotelProject.DtoLayer.Dtos.AboutDto.Requests;
using HotelProject.DtoLayer.Dtos.ContactDto.Requests;
using HotelProject.DtoLayer.Dtos.ContactDto.Responses;
using HotelProject.DtoLayer.Dtos.GuestDto.Requests;
using HotelProject.DtoLayer.Dtos.GuestDto.Responses;
using HotelProject.DtoLayer.Dtos.RoomDto.Requests;
using HotelProject.DtoLayer.Dtos.SendMessageDto.Requests;
using HotelProject.DtoLayer.Dtos.SendMessageDto.Responses;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddRoomRequest,Room>().ReverseMap();
            CreateMap<UpdateRoomRequest,Room>().ReverseMap();
            CreateMap<AddAboutRequest, About>().ReverseMap();
            CreateMap<UpdateAboutRequest, About>().ReverseMap();

            CreateMap<CreateContactRequest, Contact>().ReverseMap();
            CreateMap<UpdateContactRequest, Contact>().ReverseMap();
            CreateMap<DisplayContactResponse, Contact>().ReverseMap();

            CreateMap<CreateGuestRequest, Guest>().ReverseMap();
            CreateMap<UpdateGuestRequest, Guest>().ReverseMap();
            CreateMap<DisplayGuestResponse, Guest>().ReverseMap();

            CreateMap<CreateSendMessageRequest, SendMessage>().ReverseMap();
            CreateMap<UpdateSendMessageRequest, SendMessage>().ReverseMap();
            CreateMap<DisplaySendMessageResponse, SendMessage>().ReverseMap();

        }
    }
}

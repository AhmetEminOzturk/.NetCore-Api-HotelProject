using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto.Requests;
using HotelProject.WebUI.Dtos.AboutDto.Responses;
using HotelProject.WebUI.Dtos.BookingDto.Requests;
using HotelProject.WebUI.Dtos.BookingDto.Responses;
using HotelProject.WebUI.Dtos.ContactDto.Requests;
using HotelProject.WebUI.Dtos.ContactDto.Responses;
using HotelProject.WebUI.Dtos.GuestDto.Requests;
using HotelProject.WebUI.Dtos.GuestDto.Responses;
using HotelProject.WebUI.Dtos.LoginDto.Requests;
using HotelProject.WebUI.Dtos.RegisterDto.Requests;
using HotelProject.WebUI.Dtos.ReservationDto.Requests;
using HotelProject.WebUI.Dtos.RoomDto.Requests;
using HotelProject.WebUI.Dtos.RoomDto.Responses;
using HotelProject.WebUI.Dtos.SendMessageDto.Requests;
using HotelProject.WebUI.Dtos.SendMessageDto.Responses;
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
            CreateMap<UpdateRoomRequest, Room>().ReverseMap();
            CreateMap<CreateRoomRequest, Room>().ReverseMap();
            CreateMap<DisplayStaffResponse, Staff>().ReverseMap();

            CreateMap<DisplayBookingResponse, Booking>().ReverseMap();
            CreateMap<CreateBookingRequest, Booking>().ReverseMap();
            CreateMap<UpdateBookingRequest, Booking>().ReverseMap();
            CreateMap<UpdateReservationRequest, Booking>().ReverseMap();

            CreateMap<DisplayContactResponse, Contact>().ReverseMap();
            CreateMap<CreateContactRequest, Contact>().ReverseMap();
            CreateMap<UpdateContactRequest, Contact>().ReverseMap();

            CreateMap<CreateSubscribeRequest, Subscribe>().ReverseMap();

            CreateMap<CreateGuestRequest, Guest>().ReverseMap();
            CreateMap<UpdateGuestRequest, Guest>().ReverseMap();
            CreateMap<DisplayGuestResponse, Guest>().ReverseMap();

            CreateMap<CreateSendMessageRequest, SendMessage>().ReverseMap();
            CreateMap<UpdateSendMessageRequest, SendMessage>().ReverseMap();
            CreateMap<DisplaySendMessageResponse, SendMessage>().ReverseMap();
        }
    }
}

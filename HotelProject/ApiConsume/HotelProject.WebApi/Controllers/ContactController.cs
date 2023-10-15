using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.ContactDto.Requests;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _ContactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService ContactService, IMapper mapper)
        {
            _ContactService = ContactService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _ContactService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddContact(CreateContactRequest createContactRequest)
        {
            createContactRequest.Date = Convert.ToDateTime(DateTime.Now.ToString());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Contact>(createContactRequest);
            _ContactService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var values = _ContactService.TGetById(id);
            _ContactService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactRequest updateContactRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Contact>(updateContactRequest);
            _ContactService.TUpdate(values);
            return Ok("Güncelleme işlemi başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var values = _ContactService.TGetById(id);
            return Ok(values);
        }
    }
}

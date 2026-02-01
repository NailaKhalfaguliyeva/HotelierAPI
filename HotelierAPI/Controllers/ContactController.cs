using Hotelier.Api.BusinessLayer.Abstract;
using Hotelier.Api.DtoLayer.Dtos.ContactDto;
using Hotelier.Api.EntityLayer.Concrete;

using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public IActionResult AddContact(CreateContactDto createContactDto)
        {
            var contact = new Contact
            {
                Email = createContactDto.Email,
                Message = createContactDto.Message,
                Name = createContactDto.Name,
                Subject = createContactDto.Subject,
                Date = DateTime.Now,
                MessageCategoryID = 1
            };

            _contactService.TInsert(contact);
            return Ok();
        }

        [HttpGet]
        public IActionResult InboxListContact()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contactService.TGetByID(id);
            return Ok(values);
        }

        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
          return Ok( _contactService.TGetContactCount());
        }

    }
}

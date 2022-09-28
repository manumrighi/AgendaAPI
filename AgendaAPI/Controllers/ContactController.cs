using AgendaAPI.Data.Repository;
using AgendaAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private ContactRepository _contactRepository { get; set; }
        public ContactController(ContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_contactRepository.GetAllContacts());
        }

        [HttpGet]
        [Route("GetOne/{Id}")]

        public IActionResult GetOneById(int Id)
        {
            return Ok(_contactRepository.GetAllContacts().Where(x => x.Id == Id).ToList());
        }
    }
}


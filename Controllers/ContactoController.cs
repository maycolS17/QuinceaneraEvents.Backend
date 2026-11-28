using Microsoft.AspNetCore.Mvc;
using QuinceaneraEvents.Backend.DTOs;
using QuinceaneraEvents.Backend.Services;

namespace QuinceaneraEvents.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactoController : ControllerBase
    {
        private readonly ContactoService _contactoService;

        public ContactoController(ContactoService contactoService)
        {
            _contactoService = contactoService;
        }

        [HttpPost]
        public async Task<ActionResult<ContactoResponseDto>> CreateContacto(
            [FromBody] CreateContactoDto dto)
        {
            var respuesta = await _contactoService.CreateContactoAsync(dto);

            return CreatedAtAction(
                nameof(CreateContacto),
                new { id = respuesta.Id },
                respuesta);
        }
    }
}

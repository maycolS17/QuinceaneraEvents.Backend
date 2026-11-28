using Microsoft.EntityFrameworkCore;
using QuinceaneraEvents.Backend.Data;
using QuinceaneraEvents.Backend.DTOs;
using QuinceaneraEvents.Backend.Entities;

namespace QuinceaneraEvents.Backend.Services
{
    public class ContactoService
    {
        private readonly AppDbContext _context;

        public ContactoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ContactoResponseDto> CreateContactoAsync(
            CreateContactoDto dto)
        {
            var contacto = new Contacto
            {
                Name = dto.Name,
                Email = dto.Email,
                Phone = dto.Phone,
                EventType = dto.EventType,
                Message = dto.Message,
                RegisterDate = DateTime.UtcNow
            };

            _context.Contactos.Add(contacto);
            await _context.SaveChangesAsync();

            return new ContactoResponseDto
            {
                Id = contacto.Id,
                Name = contacto.Name,
                RegisterDate = contacto.RegisterDate
            };
        }
    }
}

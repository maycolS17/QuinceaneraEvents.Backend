using Microsoft.EntityFrameworkCore;
using QuinceaneraEvents.Backend.Entities;

namespace QuinceaneraEvents.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Contacto> Contactos { get; set; }
    }
}
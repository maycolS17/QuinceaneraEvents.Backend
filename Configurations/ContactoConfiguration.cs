using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuinceaneraEvents.Backend.Entities;

namespace QuinceaneraEvents.Backend.Configurations
{
    public class ContactoConfiguration : IEntityTypeConfiguration<Contacto>
    {
        public void Configure(EntityTypeBuilder<Contacto> builder)
        {
            builder.ToTable("Contacts");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(150);

            builder.Property(c => c.Email).IsRequired().HasMaxLength(150);

            builder.Property(c => c.Phone).IsRequired().HasMaxLength(20);

            builder.Property(c => c.EventType).IsRequired().HasMaxLength(100);

            builder.Property(c => c.EventDate);

            builder.Property(c => c.GuestCount);

            builder.Property(c => c.Message);

            builder.Property(c => c.RegisterDate).IsRequired();

            builder.Property(c => c.ApplicationStatus).IsRequired().HasMaxLength(30);

            builder.Property(c => c.NotificationStatus).IsRequired().HasMaxLength(30);
        }
    }
}
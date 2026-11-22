namespace QuinceaneraEvents.Backend.Entities
{
    public class Contacto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string EventType { get; set; } = string.Empty;
        public DateTime? EventDate { get; set; } 
        public int? GuestCount { get; set; }
        public string? Message { get; set; }
        public DateTime RegisterDate { get; set; }
        public string ApplicationStatus { get; set; } = "Pending";
        public string NotificationStatus { get; set; } = "Pending";
    }
}

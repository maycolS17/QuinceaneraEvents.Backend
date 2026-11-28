namespace QuinceaneraEvents.Backend.DTOs
{
    public class CreateContactoDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(150, ErrorMessage = "El nombre no puede exceder los 150 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del correo no es valido")]
        [MaxLength(150, ErrorMessage = "El correo electronico no puede exceder los 150 caracteres")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "El numero de telefono es obligatorio")]
        [MaxLength(20, ErrorMessage = "El numero de telefono no puede exceder los 20 caracteres")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "El tipo de evento es obligatorio")]
        [MaxLength(150, ErrorMessage = "El tipo de evento no puede exceder los 150 caracteres")]
        public string EventType { get; set; } = string.Empty;

        [MaxLength(1000, ErrorMessage = "El mensaje no puede exceder los 1000 caracteres")]
        public string? Message { get; set; } = string.Empty;
    }
}

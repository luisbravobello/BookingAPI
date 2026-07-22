using System.ComponentModel.DataAnnotations;

namespace BookingAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [StringLength(20)]
        public string Telefono { get; set; } = string.Empty;

        // Propiedad de navegación Un cliente puede tener muchas reservas
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}

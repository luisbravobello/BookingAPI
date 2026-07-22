using System.ComponentModel.DataAnnotations;

namespace BookingAPI.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; } // Relación con Cliente

        [Required]
        public int ServicioId { get; set; }
        public Servicio? Servicio { get; set; } // Relación con Servicio

        [Required]
        public DateTime FechaHoraInicio { get; set; }

        [Required]
        public DateTime FechaHoraFin { get; set; }

        [Required]
        public EstadoReserva Estado { get; set; } = EstadoReserva.Pendiente;
    }
}
using System.ComponentModel.DataAnnotations;

namespace BookingAPI.DTOs
{
    public class CrearReservaDTO
    {
        [Required]
        public int ClienteId { get; set; }

        [Required]
        public int ServicioId { get; set; }

        [Required]
        public DateTime FechaHoraInicio { get; set; }

        [Required]
        public DateTime FechaHoraFin { get; set; }
    }
}
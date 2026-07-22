using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingAPI.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public int DuracionMinutos { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
    }
}
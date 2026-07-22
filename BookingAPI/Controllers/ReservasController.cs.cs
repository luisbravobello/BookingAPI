using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookingAPI.Data;
using BookingAPI.Models;
using BookingAPI.DTOs;

namespace BookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        // Inyectamos la base de datos en el controlador
        public ReservasController(ApplicationDbContext context)
        {
            _context = context;
        }


        // POST: Api/Reservas
        [HttpPost]
        public async Task<IActionResult> CrearReserva([FromBody] CrearReservaDTO dto)
        {

            if (dto.FechaHoraFin <= dto.FechaHoraInicio)
            {
                return BadRequest("La fecha de fin debe ser posterior a la fecha de inicio.");
            }

           
            bool existeSolapamiento = await _context.Reservas
                .AnyAsync(r => r.ServicioId == dto.ServicioId &&
                               r.Estado != EstadoReserva.Cancelada &&
                               dto.FechaHoraInicio < r.FechaHoraFin &&
                               dto.FechaHoraFin > r.FechaHoraInicio);

            if (existeSolapamiento)
            {
                return Conflict("El horario seleccionado ya está ocupado para este servicio.");
            }

            // 3. Si todo está libre, creamos la reserva real
            var nuevaReserva = new Reserva
            {
                ClienteId = dto.ClienteId,
                ServicioId = dto.ServicioId,
                FechaHoraInicio = dto.FechaHoraInicio,
                FechaHoraFin = dto.FechaHoraFin,
                Estado = EstadoReserva.Pendiente
            };

            _context.Reservas.Add(nuevaReserva);
            await _context.SaveChangesAsync();

            return Ok(new { Mensaje = "Reserva creada exitosamente", ReservaId = nuevaReserva.Id });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookingAPI.Data;
using BookingAPI.Models;

namespace BookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {

        // Inyectamos la base de datos en el controlador
        private readonly ApplicationDbContext _context;

        // Constructor del controlador
        public ServiciosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/servicios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servicio>>> GetServicios()
        {
            return await _context.Servicios.ToListAsync();
        }

        // POST: api/servicios
        [HttpPost]
        public async Task<ActionResult<Servicio>> PostServicio(Servicio servicio)
        {
            _context.Servicios.Add(servicio);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetServicios), new { id = servicio.Id }, servicio);
        }
    }
}
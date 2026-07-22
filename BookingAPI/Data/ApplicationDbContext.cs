using Microsoft.EntityFrameworkCore;
using BookingAPI.Models;

namespace BookingAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // tablas de SQL Server
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        // Configuración de índices y relaciones

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reserva>()
                .HasIndex(r => r.FechaHoraInicio);
        }
    }
}
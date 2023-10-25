using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace Back.src.ProEventos.API.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Evento> Eventos { get; set; }
    }
}

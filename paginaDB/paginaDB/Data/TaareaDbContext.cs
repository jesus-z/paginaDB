using Microsoft.EntityFrameworkCore;
using paginaDB.Models;

namespace paginaDB.Data
{
    public class TareaDbContext : DbContext
    {
        public TareaDbContext(DbContextOptions<TareaDbContext> options) : base(options)
        {
        }
        public DbSet<Tarea> Tareas { get; set; }
        protected TareaDbContext()
        {
        }
    }
}

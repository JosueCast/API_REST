using InventarioBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioBackend.Data
{
    //agregamos nuestro coontexto de la db y sus contructores
    public class ApplicationsDbContext : DbContext
    {
        public ApplicationsDbContext(DbContextOptions<ApplicationsDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using MiPrimerApi.Models;

namespace MiPrimerApi.Context
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<Producto> Producto { get; set; }
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options)
        : base(options)
        {
        }
    }
}

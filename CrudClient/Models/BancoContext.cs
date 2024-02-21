using CrudClient.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CrudClient.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options):base(options)
        {

        }
        public DbSet<Clientes> Clientes { get; set; }
    }
}


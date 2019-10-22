using Microsoft.EntityFrameworkCore;
using VNVon.DataAccess.Models;

namespace VNVon.DataAccess
{
    public class Context: DbContext
    {
        public Context(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Domain> Domains { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using VNVon.DataAccess.Models;

namespace VNVon.DataAccess
{
    public class VNVonContext: DbContext
    {
        public VNVonContext(DbContextOptions<VNVonContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Domain> Domains { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

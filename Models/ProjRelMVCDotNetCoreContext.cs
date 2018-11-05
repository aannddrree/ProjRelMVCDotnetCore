using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class ProjRelMVCDotNetCoreContext : DbContext
    {
        public ProjRelMVCDotNetCoreContext (DbContextOptions<ProjRelMVCDotNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ProjRelMVCDotnetCore.Models.Hotel> Hotel { get; set; }
        public DbSet<ProjRelMVCDotnetCore.Models.Quarto> Quarto { get; set; }
    }
}
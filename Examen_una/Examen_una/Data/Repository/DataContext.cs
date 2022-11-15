using Examen_una.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Examen_una.Data.Repository
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<Plantas> plantas { get; set; }
        public DbSet<Riego> riegos { get; set; }
        
    }
}

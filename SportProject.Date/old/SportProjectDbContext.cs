using Microsoft.EntityFrameworkCore;
using SportProject.Core;

namespace SportProject.Data
{
    public class SportProjectDbContext : DbContext
    {
        public SportProjectDbContext(DbContextOptions<SportProjectDbContext> options)
                : base(options)
        {

        }
        public DbSet<Form> Forms { get; set; }
    }
}

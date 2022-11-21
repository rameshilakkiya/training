using Microsoft.EntityFrameworkCore;

namespace weektestapi.Models
{
    public class usercontext : DbContext
    {
        public usercontext(DbContextOptions<usercontext> options) : base(options) { }
        public DbSet<user> users { get; set; } = null!;
        public DbSet<serviceprovider> serviceproviders { get; set; } = null!;
    }
}

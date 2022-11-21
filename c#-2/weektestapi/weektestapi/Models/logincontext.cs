using Microsoft.EntityFrameworkCore;

namespace weektestapi.Models
{
    public class logincontext : DbContext
    {
        public logincontext(DbContextOptions<logincontext> options) : base(options) { }
        public DbSet<user> users { get; set; } = null!;


    }
}

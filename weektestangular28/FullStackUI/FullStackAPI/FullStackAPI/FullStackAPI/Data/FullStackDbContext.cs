using FullStackAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStackAPI.Data
{
    public class FullStackDbContext:DbContext
    {
        public FullStackDbContext(DbContextOptions<FullStackDbContext> options) : base(options) { }
        public DbSet<Employee> Employee { get; set; } = null!;
    }
}

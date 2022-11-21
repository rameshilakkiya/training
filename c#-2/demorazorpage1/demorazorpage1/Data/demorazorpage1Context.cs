using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demorazorpage1.Models;

namespace demorazorpage1.Data
{
    public class demorazorpage1Context : DbContext
    {
        public demorazorpage1Context (DbContextOptions<demorazorpage1Context> options)
            : base(options)
        {
        }

        public DbSet<demorazorpage1.Models.Movie> Movie { get; set; } = default!;
    }
}

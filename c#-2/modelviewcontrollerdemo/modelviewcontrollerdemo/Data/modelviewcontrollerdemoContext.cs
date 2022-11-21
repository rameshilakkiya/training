using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modelviewcontrollerdemo.Models;

namespace modelviewcontrollerdemo.Data
{
    public class modelviewcontrollerdemoContext : DbContext
    {
        public modelviewcontrollerdemoContext (DbContextOptions<modelviewcontrollerdemoContext> options)
            : base(options)
        {
        }

        public DbSet<modelviewcontrollerdemo.Models.Movie> Movie { get; set; } = default!;
    }
}

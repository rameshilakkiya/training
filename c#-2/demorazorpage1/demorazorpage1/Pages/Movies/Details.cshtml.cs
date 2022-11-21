using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using demorazorpage1.Data;
using demorazorpage1.Models;

namespace demorazorpage1.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly demorazorpage1.Data.demorazorpage1Context _context;

        public DetailsModel(demorazorpage1.Data.demorazorpage1Context context)
        {
            _context = context;
        }

      public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}

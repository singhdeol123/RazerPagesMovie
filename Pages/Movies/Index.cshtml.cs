using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazerPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazerPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazerPagesMovie.Data.RazerPagesMovieContext _context;

        public IndexModel(RazerPagesMovie.Data.RazerPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

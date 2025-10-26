using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorWebappMoviedatabase.Models;

namespace BlazorWebAppMovies.Data
{
    public class BlazorWebAppMoviesContext : DbContext
    {
        public BlazorWebAppMoviesContext (DbContextOptions<BlazorWebAppMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebappMoviedatabase.Models.Movie> Movie { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RighteousMovies.Models;

namespace RighteousMovies.Data
{
    public class RighteousMoviesContext : DbContext
    {
        public RighteousMoviesContext (DbContextOptions<RighteousMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<RighteousMovies.Models.Movie> Movie { get; set; } = default!;
    }
}

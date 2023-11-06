using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RighteousMovies.Data;
using RighteousMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RighteousMovies.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RighteousMoviesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RighteousMoviesContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            var movies = new Movie[] {

                //context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 7.99M,
                        ImageName = "thermorg.jpg"
                    },
                    new Movie
                    {
                        Title = "Other Side of Heaven ",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 8.99M,
                        ImageName = "othersideofheavenorg.jpg"
                    },
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 9.99M,
                        ImageName="meetthemormonsorg.jpg"
                    }
                //);
            };
            context.SaveChanges();
        }
    }
}
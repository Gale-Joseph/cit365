using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-01-01"),
                        Genre = "Comedy",
                        Price = 7.99M,
                        Rating= "PG",
                        ImagePath="~/images/rm.jpg"
                    },

                    new Movie
                    {
                        Title = "Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2000-01-01"),
                        Genre = "Family",
                        Price = 8.99M,
                        Rating = "PG",
                        ImagePath = "~/images/otherside.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2016-01-01"),
                        Genre = "Documentary",
                        Price = 9.99M,
                        Rating = "PG",
                        ImagePath = "~/images/meet.jpg"
                    },
                    new Movie
                    {
                        Title = "Charly",
                        ReleaseDate = DateTime.Parse("2000-01-01"),
                        Genre = "Drama",
                        Price = 9.99M,
                        Rating = "PG",
                        ImagePath = "~/images/charly.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
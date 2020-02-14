//nuget package manager>package Manager console > add-migration Intital 
//coordinates EF CORE functionality(CRUD) for Models/Movie.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    //handles connecting to DB and mapping Movie objects to database records
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        //create a way to access the movie class in Models/Movie.cs?
        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}

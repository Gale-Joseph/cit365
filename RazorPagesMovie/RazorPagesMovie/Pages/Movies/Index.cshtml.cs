using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesMovie
{
    //razor pages derived from PageModel
    public class IndexModel : PageModel
    {
        //dependency injetion used to add RazorPagesMovieContext
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        //dependency injetion used to add RazorPagesMovieContext
        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }
     
        //bind values/query strings with same name as property
        [BindProperty(SupportsGet = true)]
        //text that user will input
        public string SearchString { get; set; }
        
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        //When request is made for page, OnGetAsync returns list of moview

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres, LINQ query to get genres from database
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movie
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}

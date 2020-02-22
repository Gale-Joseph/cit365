using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyScriptureJournal
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }        
       
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }      

        [BindProperty(SupportsGet = true)]
        public string SearchStringNotes{get; set; }

        //razor-tutorial
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentFilterNotes { get; set; }
        public string CurrentSort { get; set; }
        public PaginatedList<Scripture> Scriptures { get; set; }
      
        //end razaor-tutorial


        /* ######################## async Task OnGetAsync #####################################*/
        public async Task OnGetAsync(string sortOrder, string currentFilter, string SearchString, string currentFilterNotes, string SearchStringNotes, int? pageIndex)
        {

            //select all scriptures from database
            var scriptures = from s in _context.Scripture
                         select s;

            //this allows filters to be used
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(SearchStringNotes))
            {
                scriptures = scriptures.Where(x => x.Notes.Contains(SearchStringNotes));
            }

            //razor-tutorial
            CurrentSort = sortOrder;
            NameSort = sortOrder== "Book" ? "name_desc" : "Book"; 
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            if (SearchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                SearchString = currentFilter;
               
            }
            if (SearchStringNotes != null)
            {
                pageIndex = 1;
            }
            else
            {
                SearchStringNotes = currentFilterNotes;

            }
           

            CurrentFilter = SearchString;
            CurrentFilterNotes = SearchStringNotes;
          
            IQueryable<Scripture> scripturesIQ = from s in _context.Scripture select s;

            /*If either scripture search string or notes search string is filled in
             * scriptureIQ will contain whatever is in the fields*/

            if (!String.IsNullOrEmpty(SearchString)|| !String.IsNullOrEmpty(SearchStringNotes))
            {
                scripturesIQ = scripturesIQ.Where(s => s.Book.Contains(SearchString)
                                       || s.Notes.Contains(SearchStringNotes));
            }

            /*If BOTH scripture search string AND notes search string are filled in
             * scriptureIQ will contain scriptures with BOTH arguments */
            if (!String.IsNullOrEmpty(SearchString) & !String.IsNullOrEmpty(SearchStringNotes))
            {
                scripturesIQ = scripturesIQ.Where(s => s.Book.Contains(SearchString)
                                       & s.Notes.Contains(SearchStringNotes));
            }

            //create a process for when scripture and date are clicked to toggle order:
            switch (sortOrder)
            {
                case "name_desc":
                    scripturesIQ = scripturesIQ.OrderByDescending(s => s.Book); 
                    break;
                case "Date":
                    scripturesIQ = scripturesIQ.OrderBy(s => s.AddedDate);
                    break;
                case "date_desc":
                    scripturesIQ = scripturesIQ.OrderByDescending(s => s.AddedDate);
                    break;
                case "Book":
                    scripturesIQ = scripturesIQ.OrderBy(s => s.Book);
                    break;
                default:
                    scripturesIQ = scripturesIQ.OrderByDescending(s => s.Book);
                    break;
            }

/*            int pageSize = 3;
            Scriptures = await PaginatedList<Scripture>.CreateAsync(
                scripturesIQ.AsNoTracking(), pageIndex ?? 1, pageSize);*/


            if (sortOrder == null)
            {
                Scripture = await scriptures.ToListAsync();
            }
            else
            {
                Scripture = await scripturesIQ.AsNoTracking().ToListAsync();
            }
        }

    }
}

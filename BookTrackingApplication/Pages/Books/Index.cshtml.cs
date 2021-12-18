using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTrackingApplication.Data;
using BookTrackingApplication.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookTrackingApplication.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookTrackingApplication.Data.BookTrackingApplicationContext _context;

        public IndexModel(BookTrackingApplication.Data.BookTrackingApplicationContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookGenre { get; set; }

        public async Task OnGetAsync()
        {

            IQueryable<string> genreQuery = from m in _context.Book
                                            orderby m.Category
                                            select m.Category;

            var books = from m in _context.Book
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(BookGenre))
            {
                books = books.Where(x => x.Category == BookGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

            Book = await _context.Book.ToListAsync();
        }
    }
}

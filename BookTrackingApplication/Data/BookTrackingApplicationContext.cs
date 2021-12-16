using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTrackingApplication.Models;

namespace BookTrackingApplication.Data
{
    public class BookTrackingApplicationContext : DbContext
    {
        public BookTrackingApplicationContext (DbContextOptions<BookTrackingApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<BookTrackingApplication.Models.Book> Book { get; set; }
    }
}

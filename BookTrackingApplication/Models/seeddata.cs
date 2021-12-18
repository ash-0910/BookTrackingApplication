using BookTrackingApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackingApplication.Models
{
    public class seeddata
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookTrackingApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookTrackingApplicationContext>>()))
            {
                // Look for any books.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        ISBN = "1338716530",
                        Title = "Harry Potter and the Chamber of Secrets (MinaLima Edition)(2)",
                        Category = "Adventure",
                        Author = "J. K. Rowling"
                    },

                    new Book
                    {
                        ISBN = "9780545828857",
                        Title = "The Haunted Car (Classic Goosebumps #30)",
                        Category = "Horror",
                        Author = "R.L. Stine"
                    },

                    new Book
                    {
                        ISBN = "059335866X",
                        Title = "Star Wars Visions: Ronin",
                        Category = "Action",
                        Author = "Candon, Emma Mieko"
                    },

                    new Book
                    {
                        ISBN = "9781681160979",
                        Title = "Lost in Space Ultimate Collection",
                        Category = "Adventure",
                        Author = "Dinnick, Richard; Buccellato, Brian"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

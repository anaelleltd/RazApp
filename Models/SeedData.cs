using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazApp.Data;
using System;
using System.Linq;

namespace RazApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazAppContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Forty Rules of Love",
                        ReleaseDate = DateTime.Parse("2009-3-6"),
                        Genre = "Literary Fiction",
                        Price = 18.99M
                    },
                    new Book
                    {
                        Title = "Americanah",
                        ReleaseDate = DateTime.Parse("2013-5-14"),
                        Genre = "Fiction",
                        Price = 16.00M
                    },

                    new Book
                    {
                        Title = "We need new names",
                        ReleaseDate = DateTime.Parse("2013-6-7"),
                        Genre = "African Fiction",
                        Price = 17.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

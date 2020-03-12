using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any scriptures
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = 3,
                        Verse = 7,
                        Notes = "#obedience #obey",
                        AddedDate = DateTime.Parse("2020-2-05"),
                    },
                    new Scripture
                    {
                        Book = "2 Nephi",
                        Chapter = 2,
                        Verse = 25,
                        Notes = "#joy",
                        AddedDate = DateTime.Parse("2020-2-04"),
                    },
                    new Scripture
                    {
                        Book = "Mosiah",
                        Chapter = 2,
                        Verse = 32,
                        Notes = "#obedience #obey",
                        AddedDate = DateTime.Parse("2020-2-03"),
                    },
                    new Scripture
                    {
                        Book = "Genesis",
                        Chapter = 2,
                        Verse = 16,
                        Notes = "#agency #choice",
                        AddedDate = DateTime.Parse("2020-2-02"),
                    },
                    new Scripture
                    {
                        Book = "2 Nephi",
                        Chapter = 2,
                        Verse = 27,
                        Notes = "#agency #free",
                        AddedDate = DateTime.Parse("2020-2-01"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
    


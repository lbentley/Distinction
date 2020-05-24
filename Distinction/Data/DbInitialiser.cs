using Distinction.Models;
using System.Linq;

namespace Distinction.Data
{
    public static class DbInitialiser
    {
        public static void Initialiser(BooksContext context)
        {
            context.Database.EnsureCreated();

            if(context.Books.Any())
            {
                return;
            }

            var books = new Book[]
            {
                new Book{Title="Harvest", Authors="Jim Crace"},
                new Book{Title="Danubia", Authors="Simon Winder"},
                new Book{Title="The Pesthouse", Authors="Jim Crace"},
                new Book{Title="The Counsellor", Authors="Jim Crace, Simon Winder"}
            };

            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();

            var reviews = new Review[]
            {
                new Review{Name="Joe Bloggs", Email="joe.bloggs@email.com", Score=5, Comments="Excellent read!", BookID=1},
                new Review{Name="Jane Bloggs", Email="jane.bloggs@email.com", Score=1, Comments="Rubbish", BookID=1},
                new Review{Name="Jane Bloggs", Email="jane.bloggs@email.com", Score=3, Comments="Mediocre", BookID=2}
            };

            foreach ( Review r in reviews)
            {
                context.Reviews.Add(r);
            }
            context.SaveChanges();
        }
    }
}

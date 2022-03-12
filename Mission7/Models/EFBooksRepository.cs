using System;
using System.Linq;

namespace Mission7.Models
{
    public class EFBooksRepository : IBooksRepository
    {
        private BookstoreContext context { get; set; }

        public EFBooksRepository(BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Books> Books => context.Books;

        public void SaveBook(Books b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Books b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Books b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}

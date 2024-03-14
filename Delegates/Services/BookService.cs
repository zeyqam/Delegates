using Delegates.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Delegates.Services
{
    public class BookService : IBookService
    {
        public int CountBooksByAuthor(List<Book> books, string author)
        {
            Predicate<Book> predicate = b => b.Author == author;
            int count = CountBooks(books, predicate);
            return count;
        }
        private int CountBooks(List<Book> books, Predicate<Book> predicate)
        {
            int count = 0;
            foreach (var book in books)
            {
                if (predicate(book))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

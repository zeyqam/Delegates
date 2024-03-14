using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Services.Interfaces
{
    public interface IBookService
    {
        int CountBooksByAuthor(List<Book> books, string author);
    }
}

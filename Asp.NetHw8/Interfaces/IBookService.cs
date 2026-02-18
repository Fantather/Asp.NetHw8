using Asp.NetHw8.Models;

namespace Asp.NetHw8.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        void Add(Book book);
    }
}

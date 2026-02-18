using Asp.NetHw8.Models;

namespace Asp.NetHw8.ViewModels
{
    public record class BookViewModel(string Title, string Author, string Genre, int Year)
    {
        public Book ToBook()
        {
            return new Book(Title, Author, Genre, Year);
        }
    }
}

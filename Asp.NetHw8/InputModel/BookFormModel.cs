using Asp.NetHw8.Models;

namespace Asp.NetHw8.InputModel
{
    public class BookFormModel(string Title, string Author, string Genre, int Year, List<IFormFile>? Images)
    {
        public Book ToBook()
        {
            return new Book(Title, Author, Genre, Year, Images);
        }
    }
}

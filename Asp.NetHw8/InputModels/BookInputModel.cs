using Asp.NetHw8.Models;
using Asp.NetHw8.Services;

namespace Asp.NetHw8.InputModels
{
    public record class BookInputModel(string Title, string Author, string Genre, int Year, List<IFormFile>? Images)
    {
        public async Task<Book> ToBook()
        {
            IEnumerable<string> imagePaths = Images is null ? "" : await FileStorageService.SaveImagesAsync(Images);
            return new Book(Title, Author, Genre, Year, imagePaths);
        }
    }
}

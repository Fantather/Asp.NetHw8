using Asp.NetHw8.InputModels;
using Asp.NetHw8.Models;
using Asp.NetHw8.Services;
using Asp.NetHw8.ViewModels;
using Humanizer.Localisation;
using static System.Net.Mime.MediaTypeNames;

namespace Asp.NetHw8.Mappers
{
    public static class BookMappingExtensions
    {
        public async static Task<Book> ToBook(this BookInputModel inputModel)
        {
            IEnumerable<string> imagePaths = inputModel.Images is null ? Enumerable.Empty<string>() : await FileStorageService.SaveImagesAsync(inputModel.Images);
            return new Book(inputModel.Title, inputModel.Author, inputModel.Genre, inputModel.Year, imagePaths);
        }

        public static BookViewModel ToViewModel(this Book book)
        {
            return new BookViewModel(book.Id, book.Title, book.Author, book.Genre, book.Year, book.ImagePaths);
        }
    }
}

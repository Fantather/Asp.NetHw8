using Asp.NetHw8.InputModels;
using Asp.NetHw8.Models;
using Asp.NetHw8.Services;
using Humanizer.Localisation;
using static System.Net.Mime.MediaTypeNames;

namespace Asp.NetHw8.Helpers
{
    public static class BookConverter
    {
        public async static Task<Book> ToBook(BookInputModel inputModel)
        {
            IEnumerable<string> imagePaths = inputModel.Images is null ? "" : await FileStorageService.SaveImagesAsync(inputModel.Images);
            return new Book(inputModel.Title, inputModel.Author, inputModel.Genre, inputModel.Year, imagePaths);
        }
    }
}

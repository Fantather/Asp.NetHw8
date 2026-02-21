using Asp.NetHw8.Models;

namespace Asp.NetHw8.ViewModels
{
    public record class BookViewModel(string Title, string Author, string Genre, int Year, List<string>? ImagePaths);
}

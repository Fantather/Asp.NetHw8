using Asp.NetHw8.Models;

namespace Asp.NetHw8.ViewModels
{
    public record class BookViewModel(Guid Id, string Title, string Author, string Genre, int Year, List<string> imagePaths)
    {
        public List<string> ImagePaths { get; set; } = imagePaths.Count > 0 ? imagePaths : new List<string>() { "/images/DefaultCover.png" };
    }
}
